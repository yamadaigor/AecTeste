using AeC_Teste.Business.Entidades;
using AeC_Teste.Business.Interfaces.Repository;

namespace AeC_Teste.API.Services
{
    public class BaseService
    {
        public readonly ILogErroRepository _logErroRepository;
        public BaseService(ILogErroRepository logErroRepository)
        {
            _logErroRepository= logErroRepository;
        }
        protected void LogarErro(Exception ex,string endpoint)
        {
            _logErroRepository.Incluir(new LogErro()
            {
                TipoException = ex.GetType().Name,
                StackTrace = ex.StackTrace.ToString(),
                MensagemErro = ex.Message,
                Endpoint = endpoint,
                DataErro = DateTime.Now
            });
        }
    }
}
