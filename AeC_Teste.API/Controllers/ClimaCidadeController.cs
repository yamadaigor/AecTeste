using AeC_Teste.API.DTO;
using AeC_Teste.API.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace AeC_Teste.API.Controllers
{
    [ApiController]
    [Route("cidade")]
    public class ClimaCidadeController : Controller
    {
        private readonly IClimaCidadeService _climaCidadeService;
        public ClimaCidadeController(IClimaCidadeService climaCidadeService)
        {
            _climaCidadeService = climaCidadeService;
        }

        [HttpGet]
        [Route("clima-cidade")]
        public RetornoDTO<ClimaCidadeDTO> ObterClima(string cidade, string? siglaEstado = null)
        {
              return _climaCidadeService.ObterClimaCidades(cidade, siglaEstado);
        }
    }
}
