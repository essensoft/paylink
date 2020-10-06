using System.Text.Encodings.Web;
using System.Text.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Parser
{
    public static class JsonParser
    {
        public static readonly JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions { IgnoreNullValues = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };

        static JsonParser()
        {
            JsonSerializerOptions.Converters.Add(new StringConverter());
        }
    }
}
