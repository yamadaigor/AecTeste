using System.Text;
using System.Text.Json;

namespace AeC_Teste.API.Utils
{
    public class HttpHelper
    {
        public static T DeserializarObjetoResponse<T>(HttpResponseMessage responseMessage)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<T>(responseMessage.Content.ReadAsStringAsync().Result, options);
        }

        public static StringContent ObterConteudo(object dado)
        {
            return new StringContent(
                JsonSerializer.Serialize(dado),
                Encoding.UTF8,
                "application/json");
        }
    }
}
