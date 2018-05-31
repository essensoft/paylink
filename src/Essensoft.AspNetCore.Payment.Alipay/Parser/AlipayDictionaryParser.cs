using Newtonsoft.Json;
using System;
using System.Collections;

namespace Essensoft.AspNetCore.Payment.Alipay.Parser
{
    public class AlipayDictionaryParser<T> where T : AlipayObject
    {
        public T Parse(IDictionary parameters)
        {
            if (parameters == null || parameters.Count == 0)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            T rsp = null;

            try
            {
                var jsonText = JsonConvert.SerializeObject(parameters);
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
