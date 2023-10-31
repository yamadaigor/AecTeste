namespace AeC_Teste.Business.Entidades
{
    public class PrevisaoTempoCidade : EntidadeBase
    {
        public int IdCidade { get; set; }
     
        public string NomeCidade { get; set; }
     
        public string Estado { get; set; }

        public DateTime DataPrevisao { get; set; }

        public string Condicao { get; set; }

        public int TemperaturaMinima { get; set; }

        public int TemperaturaMaxima { get; set; }

        public int IndiceUV { get; set; }

        public string DescricaoCondicao { get; set; }
        public DateTime Data { get; set; }
    }
}
