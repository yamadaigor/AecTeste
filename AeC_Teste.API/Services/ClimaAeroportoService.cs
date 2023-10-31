using AeC_Teste.API.DTO;
using AeC_Teste.API.Interfaces.Services;
using AeC_Teste.API.Utils;
using AeC_Teste.Business.Interfaces.Repository;
using Microsoft.Extensions.Options;

namespace AeC_Teste.API.Services
{
    public class ClimaAeroportoService : BaseService, IClimaAeroportoService
    {
        private readonly HttpClient _httpClient;
        private readonly IPrevisaoTempoAeroportoRepository _previsaoTempoAeroportoRepository;

        public ClimaAeroportoService(HttpClient httpClient,
                                     IOptions<AppSettingsConfig> appSettings,
                                     IPrevisaoTempoAeroportoRepository previsaoTempoAeroportoRepository,
                                     ILogErroRepository logErroRepository) : base(logErroRepository)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(appSettings.Value.BaseUrl);
            _previsaoTempoAeroportoRepository = previsaoTempoAeroportoRepository;
        }

        public RetornoDTO<ClimaAeroportoDTO> ObterClimaAeroporto(string codigoIcao)
        {
            var retorno = new RetornoDTO<ClimaAeroportoDTO>();

            try
            {
                var response = _httpClient.GetAsync($"clima/aeroporto/{codigoIcao}").Result;

                response.EnsureSuccessStatusCode();

                var climaAeroporto = HttpHelper.DeserializarObjetoResponse<ClimaAeroportoDTO>(response);

                if (climaAeroporto == null)
                {
                    retorno.OperacaoValida = false;
                    retorno.Mensagens.Add("A clima para o aeroporto solicitado não existe de acordo com os parâmetros informados.");
                }
                else
                    retorno.Items.Add(climaAeroporto);

                // salva o retorno na base de dados
                // Fazer o mapeamento de DTO para a entidade
                _previsaoTempoAeroportoRepository
                    .Incluir(new Business.Entidades.PrevisaoTempoAeroporto()
                    {
                        CodigoIcao = climaAeroporto.CodigoIcao,
                        AtualizadoEm = climaAeroporto.AtualizadoEm,
                        PressaoAtmosferica = climaAeroporto.PressaoAtmosferica,
                        Visibilidade = climaAeroporto.Visibilidade,
                        Vento = climaAeroporto.Vento,
                        DirecaoVento = climaAeroporto.DirecaoVento,
                        Umidade = climaAeroporto.Umidade,
                        Condicao = climaAeroporto.Condicao,
                        CondicaoDescricao = climaAeroporto.CondicaoDescricao,
                        Temperatura = climaAeroporto.Temperatura,
                        Data = DateTime.Now
                    });
            }
            catch (HttpRequestException ex)
            {
                retorno.Mensagens.Add($"Ocorreu um erro inesperado: {ex.Message}. Status Code: {ex.StatusCode}");
                retorno.OperacaoValida = false;
                LogarErro(ex, nameof(ClimaAeroportoService));
            }
            catch (Exception ex)
            {
                retorno.Mensagens.Add($"Ocorreu um erro inesperado: {ex.Message}");
                retorno.OperacaoValida = false;
                LogarErro(ex, nameof(ClimaAeroportoService));
            }
            return retorno;
        }
    }
}
