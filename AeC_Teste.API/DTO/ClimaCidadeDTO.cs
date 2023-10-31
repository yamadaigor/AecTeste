using System.Text.Json.Serialization;

namespace AeC_Teste.API.DTO
{
    public class ClimaCidadeDTO
    {
        [JsonPropertyName("cidade")]
        public string Cidade { get; set; }
        [JsonPropertyName("estado")]
        public string Estado { get; set; }
        [JsonPropertyName("atualizado_em")]
        public DateTime AtualizadoEm { get; set; }
        [JsonPropertyName("clima")]
        public List<ClimaDTO> Clima { get; set; }
    }
}
