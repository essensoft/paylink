using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Parser
{
    public static class AlipayDictionaryParser
    {
        public static T Parse<T>(IDictionary<string, string> dictionary) where T : AlipayObject
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                throw new ArgumentNullException(nameof(dictionary));
            }

            T result = null;

            try
            {
                var jsonText = JsonSerializer.Serialize(dictionary, JsonParser.JsonSerializerOptions);
                result = JsonSerializer.Deserialize<T>(jsonText, JsonParser.JsonSerializerOptions);
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
