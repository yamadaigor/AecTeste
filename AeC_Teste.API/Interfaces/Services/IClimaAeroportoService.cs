using AeC_Teste.API.DTO;

namespace AeC_Teste.API.Interfaces.Services
{
    public interface IClimaAeroportoService
    {
        RetornoDTO<ClimaAeroportoDTO> ObterClimaAeroporto(string codigoIcao);
    }
}
