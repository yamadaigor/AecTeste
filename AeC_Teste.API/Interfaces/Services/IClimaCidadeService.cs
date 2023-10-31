using AeC_Teste.API.DTO;

namespace AeC_Teste.API.Interfaces.Services
{
    public interface IClimaCidadeService
    {
        RetornoDTO<ClimaCidadeDTO> ObterClimaCidades(string cidade, string? siglaEstado = null);
    }
}
