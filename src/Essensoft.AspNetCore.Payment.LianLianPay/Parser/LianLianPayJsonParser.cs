using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Parser
{
    /// <summary>
    /// LianLianPay JSON响应通用解释器。
    /// </summary>
    public class LianLianPayJsonParser<T> : ILianLianPayParser<T> where T : LianLianPayResponse
    {
        #region ILianLianPayParser<T> Members
        public T Parse(string body)
        {
            T rsp = null;
            try
            {
                rsp = JsonConvert.DeserializeObject<T>(body);

                rsp.Parameters = new LianLianPayDictionary();
                var objdic = JsonConvert.DeserializeObject<Dictionary<string, object>>(body);
                foreach (var iter in objdic)
                {
                    rsp.Parameters.Add(iter.Key, iter.Value);
                }
            }
            catch { }

            if (rsp == null)
                rsp = Activator.CreateInstance<T>();

            if (rsp != null)
                rsp.Body = body;

            return rsp;
        }
        #endregion
    }
}
