using System.Text;
using Essensoft.AspNetCore.Payment.Security;

namespace Essensoft.AspNetCore.Payment.QPay.Utility
{
    public static class QPaySignature
    {
        public static string SignWithKey(QPayDictionary dictionary, string key)
        {
            var content = new StringBuilder();
            foreach (var iter in dictionary)
            {
                if (!string.IsNullOrEmpty(iter.Value) && iter.Key != "sign")
                {
                    content.Append(iter.Key).Append('=').Append(iter.Value).Append("&");
                }
            }
            var signContent = content.Append("key=").Append(key).ToString();
            return MD5.Compute(signContent).ToUpperInvariant();
        }
    }
}
