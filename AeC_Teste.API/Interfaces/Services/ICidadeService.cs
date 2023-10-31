using AeC_Teste.API.DTO;

namespace AeC_Teste.API.Interfaces.Services
{
    public interface ICidadeService
    {
        RetornoDTO<CidadeDTO> ObterCidadePorNome(string nomeCidade, string? siglaEstado = null);
    }
}
