namespace AeC_Teste.Business.Entidades
{
    public class EntidadeBase
    {
        public EntidadeBase()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
