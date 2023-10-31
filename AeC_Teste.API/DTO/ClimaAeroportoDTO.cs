using System.Text.Json.Serialization;

namespace AeC_Teste.API.DTO
{
    public class ClimaAeroportoDTO
    {
        /// <summary>
        /// Código ICAO do aeroporto
        /// </summary>
        /// 
        [JsonPropertyName("codigo_icao")]
        public string CodigoIcao { get; set; }
        /// <summary>
        /// Data de última atualização em formato ISO.
        /// </summary>
        [JsonPropertyName("atualizado_em")]
        public string AtualizadoEm { get; set; }
        /// <summary>
        /// Pressão atmosférica medida na estação meteorológica do aeroporto expressa em hPa (Hectopascal).
        /// </summary>
        [JsonPropertyName("pressao_atmosferica")]
        public int PressaoAtmosferica { get; set; }
        /// <summary>
        /// Condição atual de visibilidade em metros.
        /// </summary>
        [JsonPropertyName("visibilidade")]
        public string Visibilidade { get; set; }
        /// <summary>
        /// Intensidade do vendo em km/h.
        /// </summary>
        [JsonPropertyName("vento")]
        public int Vento { get; set; }
        /// <summary>
        /// Direção do vento em graus (de 0° a 360°
        /// </summary>
        [JsonPropertyName("direcao_vento")]
        public int DirecaoVento { get; set; }
        /// <summary>
        /// Umidade relativa do ar em porcentagem.
        /// </summary>
        [JsonPropertyName("umidade")]
        public int Umidade { get; set; }
        /// <summary>
        /// Código da condição meteorológica
        /// </summary>
        [JsonPropertyName("condicao")]
        public string Condicao { get; set; }
        /// <summary>
        /// Texto descritivo para a condição meteorológica.
        /// </summary>
        [JsonPropertyName("condicao_Desc")]
        public string CondicaoDescricao { get; set; }
        /// <summary>
        /// Temperatura (em graus celsius)
        /// </summary>
        [JsonPropertyName("temp")]
        public float Temperatura { get; set; }
    }
}
