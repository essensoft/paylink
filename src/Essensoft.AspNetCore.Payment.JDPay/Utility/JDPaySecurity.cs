using Essensoft.AspNetCore.Payment.Security;
using Org.BouncyCastle.Crypto;
using System;
using System.Text;

namespace Essensoft.AspNetCore.Payment.JDPay.Utility
{
    public class JDPaySecurity
    {
        public static string GetSignContent(JDPayDictionary para)
        {
            if (para == null || para.Count == 0)
                return string.Empty;

            var sb = new StringBuilder();
            foreach (var iter in para)
            {
                if (!string.IsNullOrEmpty(iter.Value) && iter.Key != "sign")
                    sb.Append(iter.Key).Append("=").Append(iter.Value).Append("&");
            }

            return sb.Remove(sb.Length - 1, 1).ToString();
        }

        public static string RSASign(string sourceSignString, AsymmetricKeyParameter privateKey)
        {
            var sha256SourceSignString = SHA256.Compute(sourceSignString);
            var newsks = RSA_ECB_PKCS1Padding.Encrypt(Encoding.UTF8.GetBytes(sha256SourceSignString), privateKey);
            return Convert.ToBase64String(newsks, Base64FormattingOptions.InsertLineBreaks);
        }

        public static bool RSACheckContent(string content, string sign, AsymmetricKeyParameter publicKey)
        {
            var sha256SourceSignString = SHA256.Compute(content);
            var decryptArr = RSA_ECB_PKCS1Padding.Decrypt(Convert.FromBase64String(sign), publicKey);
            var decrypStr = Encoding.UTF8.GetString(decryptArr);
            return sha256SourceSignString.Equals(decrypStr);
        }
    }
}
