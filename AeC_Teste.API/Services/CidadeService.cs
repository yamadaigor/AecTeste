using AeC_Teste.API.DTO;
using AeC_Teste.API.Interfaces.Services;
using AeC_Teste.API.Utils;
using AeC_Teste.Business.Interfaces.Repository;
using Microsoft.Extensions.Options;

namespace AeC_Teste.API.Services
{
    public class CidadeService : BaseService,ICidadeService
    {
        private readonly HttpClient _httpClient;
        public CidadeService(HttpClient httpClient, 
                             IOptions<AppSettingsConfig> appSettings,
                             ILogErroRepository logErroRepository) : base(logErroRepository)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(appSettings.Value.BaseUrl);
        }

        public RetornoDTO<CidadeDTO> ObterCidadePorNome(string nomeCidade, string siglaEstado)
        {
            var retorno = new RetornoDTO<CidadeDTO>();

            try
            {
                var response = _httpClient.GetAsync($"cidade/{nomeCidade}").Result;

                response.EnsureSuccessStatusCode();

                // pode retornar mais de um resultado de acordo com o nome da cidade
                var cidades = HttpHelper.DeserializarObjetoResponse<List<CidadeDTO>>(response);

                if (siglaEstado != null)
                {
                    var cidade = cidades.FirstOrDefault(c => siglaEstado != null && c.Estado == siglaEstado);
                    if (cidade == null)
                    {
                        retorno.OperacaoValida = false;
                        retorno.Mensagens.Add("A cidade solicitada não existe de acordo com os parâmetros informados.");
                    }
                    else
                        retorno.Items.Add(cidade);
                }
                else
                    retorno.Items.AddRange(cidades);
            }
            catch (HttpRequestException ex)
            {
                retorno.Mensagens.Add($"Ocorreu um erro inesperado: {ex.Message}. Status Code: {ex.StatusCode}");
                retorno.OperacaoValida = false;
                LogarErro(ex, nameof(CidadeService));
            }
            catch (Exception ex)
            {
                retorno.Mensagens.Add($"Ocorreu um erro inesperado: {ex.Message}");
                LogarErro(ex, nameof(CidadeService));
            }
            return retorno;
        }
    }
}
