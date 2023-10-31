using System.Text.Json.Serialization;

namespace AeC_Teste.API.DTO
{
    public class ClimaDTO
    {
        [JsonPropertyName("data")]
        public DateTime DataPrevisao { get; set; }
        [JsonPropertyName("condicao")]
        public string Condicao { get; set; }
        [JsonPropertyName("min")]
        public int TemperaturaMinima { get; set; }
        [JsonPropertyName("max")]
        public int TemperaturaMaxima { get; set; }
        [JsonPropertyName("indice_uv")]
        public int IndiceUV { get; set; }
        [JsonPropertyName("condicao_desc")]
        public string DescricaoCondicao { get; set; }
    }
}
