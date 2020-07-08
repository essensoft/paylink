using System;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Parser
{
    public class WeChatPayObjectJsonParser<T> where T : WeChatPayObject
    {
        private static readonly JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { IgnoreNullValues = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };

        public T Parse(string body)
        {
            T result = null;

            try
            {
                if (body.StartsWith("{") && body.EndsWith("}"))
                {
                    result = JsonSerializer.Deserialize<T>(body, jsonSerializerOptions);
                }
            }
            catch { }

            if (result == null)
            {
                result = Activator.CreateInstance<T>();
            }

            return result;
        }
    }
}
