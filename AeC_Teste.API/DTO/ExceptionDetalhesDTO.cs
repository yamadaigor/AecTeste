namespace AeC_Teste.API.DTO
{
    public class ExceptionDetalhesDTO
    {
        public ExceptionDetalhesDTO()
        {
            DataErro = DateTime.Now;
        }
        public string TipoException { get; set; }
        public string StackTrace { get; set; }
        public string MensagemErro { get; set; }
        public string Endpoint { get; set; }
        public DateTime DataErro { get; set; }
    }
}
