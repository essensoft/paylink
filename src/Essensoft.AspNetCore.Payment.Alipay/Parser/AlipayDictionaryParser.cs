using System;
using System.Collections.Generic;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Parser
{
    public static class AlipayDictionaryParser
    {
        private static readonly JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { IgnoreNullValues = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };

        public static T Parse<T>(IDictionary<string, string> dictionary) where T : AlipayObject
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                throw new ArgumentNullException(nameof(dictionary));
            }

            T result = null;

            try
            {
                var jsonText = JsonSerializer.Serialize(dictionary, jsonSerializerOptions);
                result = JsonSerializer.Deserialize<T>(jsonText, jsonSerializerOptions);
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
