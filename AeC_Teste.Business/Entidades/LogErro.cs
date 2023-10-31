namespace AeC_Teste.Business.Entidades
{
    public class LogErro : EntidadeBase
    {
        public string? TipoException { get; set; }
        public string? StackTrace { get; set; }
        public string? MensagemErro { get; set; }
        public string? Endpoint { get; set; }
        public DateTime DataErro { get; set; }
    }
}
