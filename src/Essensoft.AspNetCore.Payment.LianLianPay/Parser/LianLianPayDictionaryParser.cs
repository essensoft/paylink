using System;
using System.Collections;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Parser
{
    /// <summary>
    /// LianLianPay 字典解释器。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LianLianPayDictionaryParser<T> where T : LianLianPayObject
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
