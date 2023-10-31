using AeC_Teste.API.DTO;
using AeC_Teste.API.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace AeC_Teste.API.Controllers
{
    [ApiController]
    [Route("aeroporto")]
    public class ClimaAeroportoController : Controller
    {
        private readonly IClimaAeroportoService _climaAeroportoService;
        public ClimaAeroportoController(IClimaAeroportoService climaAeroportoService)
        {
            _climaAeroportoService= climaAeroportoService;
        }
        [HttpGet]
        [Route("clima-aeroporto")]
        public RetornoDTO<ClimaAeroportoDTO> ObterClimaAeroporto(string codigoIcao)
        {
            return _climaAeroportoService.ObterClimaAeroporto(codigoIcao);
        }
    }
}
