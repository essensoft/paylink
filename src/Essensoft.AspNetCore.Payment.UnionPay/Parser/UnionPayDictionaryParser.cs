using System;
using System.Collections;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.UnionPay.Parser
{
    /// <summary>
    /// UnionPay 字典解释器。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class UnionPayDictionaryParser<T> where T : UnionPayObject
    {
        public T Parse(IDictionary dic)
        {
            if (dic == null || dic.Count == 0)
            {
                throw new ArgumentNullException(nameof(dic));
            }

            T rsp = null;

            try
            {
                var jsonText = JsonConvert.SerializeObject(dic);
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
