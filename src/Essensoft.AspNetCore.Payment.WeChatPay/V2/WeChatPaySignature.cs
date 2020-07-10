using System.Collections.Generic;
using System.Text;
using Essensoft.AspNetCore.Payment.Security;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2
{
    public static class WeChatPaySignature
    {
        public static string SignWithKey(WeChatPayDictionary dictionary, string key, WeChatPaySignType signType)
        {
            var sb = new StringBuilder();
            foreach (var iter in dictionary)
            {
                if (!string.IsNullOrEmpty(iter.Value) && iter.Key != WeChatPayConsts.sign)
                {
                    sb.Append(iter.Key).Append('=').Append(iter.Value).Append("&");
                }
            }

            var signContent = sb.Append("key=").Append(key).ToString();

            return signType switch
            {
                WeChatPaySignType.MD5 => MD5.Compute(signContent).ToUpperInvariant(),
                WeChatPaySignType.HMAC_SHA256 => HMAC_SHA256.Compute(signContent, key).ToUpperInvariant(),
                _ => throw new WeChatPayException("Unknown sign type!"),
            };
        }

        public static string SignWithSecret(WeChatPayDictionary dictionary, string secret, List<string> include)
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
            return MD5.Compute(signContent).ToUpperInvariant();
        }
    }
}
