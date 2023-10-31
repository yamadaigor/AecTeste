namespace AeC_Teste.Business.Entidades
{
    public class PrevisaoTempoAeroporto : EntidadeBase
    {
        
        public string CodigoIcao { get; set; }
        
        public string AtualizadoEm { get; set; }
        
        public int PressaoAtmosferica { get; set; }
        
        public string Visibilidade { get; set; }
        
        public int Vento { get; set; }
        
        public int DirecaoVento { get; set; }
        
        public int Umidade { get; set; }
        
        public string Condicao { get; set; }
        
        public string CondicaoDescricao { get; set; }
        
        public float Temperatura { get; set; }
        public DateTime Data { get; set; }
    }
}
