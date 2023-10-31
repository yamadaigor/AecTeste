using AeC_Teste.API.DTO;
using AeC_Teste.API.Interfaces.Services;
using AeC_Teste.API.Utils;
using AeC_Teste.Business.Entidades;
using AeC_Teste.Business.Interfaces.Repository;
using Microsoft.Extensions.Options;
using static AeC_Teste.API.Utils.LogHelper;

namespace AeC_Teste.API.Services
{
    public class ClimaCidadeService : BaseService, IClimaCidadeService
    {
        private readonly HttpClient _httpClient;
        private readonly ICidadeService _cidadeService;
        private readonly IPrevisaoTempoCidadeRepository _previsaoTempoCidadeRepository;
        private readonly ILogHelper _logHelper;
        public ClimaCidadeService(HttpClient httpClient,
                                  ICidadeService cidadeService,
                                  IPrevisaoTempoCidadeRepository previsaoTempoCidadeRepository,
                                  ILogErroRepository logErroRepository,
                                  ILogHelper logHelper,
                                  IOptions<AppSettingsConfig> appSettings) : base(logErroRepository)
        {
            _httpClient = httpClient;
            _cidadeService = cidadeService;
            _previsaoTempoCidadeRepository = previsaoTempoCidadeRepository;
            _logHelper = logHelper;
            _httpClient.BaseAddress = new Uri(appSettings.Value.BaseUrl);
        }
        public RetornoDTO<ClimaCidadeDTO> ObterClimaCidades(string nomeCidade, string? siglaEstado = null)
        {
            var retorno = new RetornoDTO<ClimaCidadeDTO>();

            try
            {
                var retornoCidades = _cidadeService.ObterCidadePorNome(nomeCidade, siglaEstado);

                if (!retornoCidades.OperacaoValida)
                {
                    retorno.OperacaoValida = retornoCidades.OperacaoValida;
                    retorno.Mensagens.AddRange(retornoCidades.Mensagens);
                }
                else
                {
                    var listaPrevisaoCidade = new List<PrevisaoTempoCidade>();

                    foreach (var cidade in retornoCidades.Items)
                    {
                        var response = _httpClient.GetAsync($"clima/previsao/{cidade.IdCidade}").Result;

                        response.EnsureSuccessStatusCode();

                        var climaCidade = HttpHelper.DeserializarObjetoResponse<ClimaCidadeDTO>(response);

                        retorno.Items.Add(climaCidade);

                        climaCidade.Clima.ForEach(clima =>
                        {
                            listaPrevisaoCidade
                                .Add(new PrevisaoTempoCidade()
                                {
                                    IdCidade = cidade.IdCidade,
                                    NomeCidade = cidade.Nome,
                                    Estado = cidade.Estado,
                                    DataPrevisao = climaCidade.AtualizadoEm,
                                    Condicao = clima.Condicao,
                                    TemperaturaMinima = clima.TemperaturaMinima,
                                    TemperaturaMaxima = clima.TemperaturaMaxima,
                                    IndiceUV = clima.IndiceUV,
                                    DescricaoCondicao = clima.DescricaoCondicao,
                                    Data = DateTime.Now
                                });
                        });
                    }
                    _previsaoTempoCidadeRepository.AddListaPrevisaoTempoCidade(listaPrevisaoCidade);
                }
            }
            catch (HttpRequestException ex)
            {
                retorno.Mensagens.Add($"Ocorreu um erro inesperado: {ex.Message}. Status Code: {ex.StatusCode}");
                retorno.OperacaoValida = false;
                LogarErro(ex, nameof(ClimaCidadeService));
            }
            catch (Exception ex)
            {
                retorno.Mensagens.Add($"Ocorreu um erro inesperado: {ex.Message}");
                retorno.OperacaoValida = false;
                LogarErro(ex, nameof(ClimaCidadeService));
            }
            return retorno;
        }
    }
}

