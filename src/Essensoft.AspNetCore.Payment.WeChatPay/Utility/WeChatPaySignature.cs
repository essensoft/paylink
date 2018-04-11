using Essensoft.AspNetCore.Payment.Security;
using System.Collections.Generic;
using System.Text;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Utility
{
    public class WeChatPaySignature
    {
        public static string SignWithKey(SortedDictionary<string, string> parameters, string key, bool useMD5 = true, bool excludeSignType = true)
        {
            var sb = new StringBuilder();
            foreach (var iter in parameters)
            {
                if (!string.IsNullOrEmpty(iter.Value) && iter.Key != "sign" && (excludeSignType ? iter.Key != "sign_type" : true))
                    sb.Append(iter.Key).Append('=').Append(iter.Value).Append("&");
            }
            var signContent = sb.Append("key=").Append(key).ToString();
            return useMD5 ? MD5.Compute(signContent).ToUpper() : HMACSHA256.Compute(signContent, key).ToUpper();
        }
    }
}
