namespace AeC_Teste.API.DTO
{
    public class RetornoDTO<T>
    {
        public RetornoDTO()
        {
            OperacaoValida = true;
            Items = new List<T>();
            Mensagens = new List<string>();
        }
        public List<T> Items { get; set; }
        public bool OperacaoValida { get; set; }
        public List<string> Mensagens { get; set; }
    }
}
