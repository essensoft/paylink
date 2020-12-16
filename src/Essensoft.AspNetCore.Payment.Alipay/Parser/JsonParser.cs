using System.Text.Encodings.Web;
using System.Text.Json;
using Essensoft.AspNetCore.Payment.Alipay.Parser.JsonConverters;

namespace Essensoft.AspNetCore.Payment.Alipay.Parser
{
    public static class JsonParser
    {
        public static readonly JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions { IgnoreNullValues = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping, AllowTrailingCommas = true };

        static JsonParser()
        {
            JsonSerializerOptions.Converters.Add(new NumberToStringConverter());
        }
    }
}
