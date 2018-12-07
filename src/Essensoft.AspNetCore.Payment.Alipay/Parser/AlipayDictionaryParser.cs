using System;
using System.Collections;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Parser
{
    public class AlipayDictionaryParser<T> where T : AlipayObject
    {
        public T Parse(IDictionary dictionary)
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                throw new ArgumentNullException(nameof(dictionary));
            }

            T rsp = null;

            try
            {
                var jsonText = JsonConvert.SerializeObject(dictionary);
                rsp = JsonConvert.DeserializeObject<T>(jsonText);
            }
            catch { }

            if (rsp == null)
            {
                rsp = Activator.CreateInstance<T>();
            }

            return rsp;
        }
    }
}
