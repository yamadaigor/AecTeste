using System.Text.Json.Serialization;

namespace AeC_Teste.API.DTO
{
    public class CidadeDTO
    {
        [JsonPropertyName("id")]
        public int IdCidade { get; set; }
        [JsonPropertyName("nome")]
        public string Nome { get; set; }
        [JsonPropertyName("estado")]
        public string Estado { get; set; }
    }
}
