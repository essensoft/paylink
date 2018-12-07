using System.Collections.Generic;
using System.Text;
using Essensoft.AspNetCore.Payment.Security;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Utility
{
    /// <summary>
    /// WeChatPay 签名类。
    /// </summary>
    public class WeChatPaySignature
    {
        public static string SignWithKey(SortedDictionary<string, string> dictionary, string key, bool signType = true, bool excludeSignType = true)
        {
            var sb = new StringBuilder();
            foreach (var iter in dictionary)
            {
                if (!string.IsNullOrEmpty(iter.Value) && iter.Key != "sign" && (excludeSignType ? iter.Key != "sign_type" : true))
                {
                    sb.Append(iter.Key).Append('=').Append(iter.Value).Append("&");
                }
            }
            var signContent = sb.Append("key=").Append(key).ToString();
            return signType ? MD5.Compute(signContent).ToUpper() : HMACSHA256.Compute(signContent, key).ToUpper();
        }

        public static string SignWithSecret(SortedDictionary<string, string> dictionary, string secret, List<string> include)
        {
            var sb = new StringBuilder();
            foreach (var iter in dictionary)
            {
                if (!string.IsNullOrEmpty(iter.Value) && include.Contains(iter.Key))
                {
                    sb.Append(iter.Key).Append('=').Append(iter.Value).Append("&");
                }
            }
            var signContent = sb.Append("secret=").Append(secret).ToString();
            return MD5.Compute(signContent).ToUpper();
        }
    }
}
