using Essensoft.AspNetCore.Security;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace Essensoft.AspNetCore.JdPay.Utility
{
    public class JdPaySignature
    {
        public static string GetSignContent(SortedDictionary<string, string> para)
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

        public static string RSASign(SortedDictionary<string, string> dic, ICipherParameters parameters)
        {
            var sourceSignString = GetSignContent(dic);
            var sha256SourceSignString = SHA256.Compute(sourceSignString);
            var newsks = Encrypt(sha256SourceSignString, parameters);
            return Convert.ToBase64String(newsks, Base64FormattingOptions.InsertLineBreaks);
        }

        public static bool RSACheckContent(SortedDictionary<string, string> dic, string sign, ICipherParameters parameters)
        {
            var strSourceData = GetSignContent(dic);
            return RSACheckContent(strSourceData, sign, parameters);
        }

        public static bool RSACheckContent(string content, string sign, ICipherParameters parameters)
        {
            var sha256SourceSignString = SHA256.Compute(content);
            var decryptArr = Decrypt(sign, parameters);
            var decrypStr = Encoding.UTF8.GetString(decryptArr);
            return sha256SourceSignString == decrypStr;
        }

        public static byte[] Encrypt(string data, ICipherParameters parameters)
        {
            var cipher = CipherUtilities.GetCipher("RSA/ECB/PKCS1Padding");
            cipher.Init(true, parameters);
            return cipher.DoFinal(Encoding.UTF8.GetBytes(data));
        }

        public static byte[] Decrypt(string data, ICipherParameters parameters)
        {
            var cipher = CipherUtilities.GetCipher("RSA/ECB/PKCS1Padding");
            cipher.Init(false, parameters);
            return cipher.DoFinal(Convert.FromBase64String(data));
        }

        public static ICipherParameters GetPrivateKeyParameters(string privateKey)
        {
            var rsaPrivStructure = RsaPrivateKeyStructure.GetInstance(Convert.FromBase64String(privateKey));
            return new RsaPrivateCrtKeyParameters(rsaPrivStructure.Modulus, rsaPrivStructure.PublicExponent, rsaPrivStructure.PrivateExponent,
                rsaPrivStructure.Prime1, rsaPrivStructure.Prime2, rsaPrivStructure.Exponent1, rsaPrivStructure.Exponent2, rsaPrivStructure.Coefficient);
        }

        public static ICipherParameters GetPublicKeyParameters(string publicKey)
        {
            return PublicKeyFactory.CreateKey(Convert.FromBase64String(publicKey));
        }
    }
}
