using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Parser
{
    public class AlipayDictionaryParser<T> where T : AlipayObject
    {
        public T Parse(IDictionary<string, string> dictionary)
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                throw new ArgumentNullException(nameof(dictionary));
            }

            T result = null;

            try
            {
                var jsonText = JsonConvert.SerializeObject(dictionary);
                result = JsonConvert.DeserializeObject<T>(jsonText);
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
