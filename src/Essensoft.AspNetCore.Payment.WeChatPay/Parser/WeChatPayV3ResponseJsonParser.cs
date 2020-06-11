using System;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Parser
{
    public class WeChatPayV3ResponseJsonParser<T> : IWeChatPayV3ResponseJsonParser<T> where T : WeChatPayV3Response
    {
        private static readonly JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { IgnoreNullValues = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };

        public T Parse(string body, int statusCode)
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

            result.Body = body;
            result.StatusCode = statusCode;
            return result;
        }
    }
}
