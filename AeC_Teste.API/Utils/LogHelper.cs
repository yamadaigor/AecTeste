using AeC_Teste.Business.Entidades;
using static AeC_Teste.API.Utils.LogHelper;

namespace AeC_Teste.API.Utils
{
    public class LogHelper : ILogHelper
    {
        private ILogger<LogHelper> _logger;
        public interface ILogHelper
        {
            void LogError(LogErro exceptioDetalhes);
            void LogInformation(string mensagem);
            void LogWarning(string mensagem);
        }

        public LogHelper(ILogger<LogHelper> logger)
        {
            _logger = logger;
        }

        public void LogInformation(string mensagem)
        {
            _logger.LogInformation(mensagem);
        }

        public void LogWarning(string mensagem)
        {
            _logger.LogWarning(mensagem);
        }

        public void LogError(LogErro logErro)
        {
            _logger.LogError(logErro.MensagemErro);
        }
    }
}
