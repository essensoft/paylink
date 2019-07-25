using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Essensoft.AspNetCore.Payment.Security;

namespace Essensoft.AspNetCore.Payment.Alipay.Utility
{
    public class AlipaySignature
    {
        public static readonly byte[] AES_IV = InitIv(16);

        public static string GetSignContent(IDictionary<string, string> dictionary)
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                return string.Empty;
            }

            var sortPara = new SortedDictionary<string, string>(dictionary);
            var sb = new StringBuilder();
            foreach (var iter in sortPara)
            {
                if (!string.IsNullOrEmpty(iter.Value))
                {
                    sb.Append(iter.Key).Append("=").Append(iter.Value).Append("&");
                }
            }

            return sb.Remove(sb.Length - 1, 1).ToString();
        }

        public static string RSASignContent(string data, string privateKey, string signType)
        {
            var key = RSAUtilities.GetRSAParametersFormRsaPrivateKey(privateKey);
            switch (signType)
            {
                case "RSA2":
                    return SHA256WithRSA.Sign(data, key);
                default:
                    return SHA1WithRSA.Sign(data, key);
            }
        }

        public static bool RSACheckContent(string data, string sign, string publicKey, string signType)
        {
            var key = RSAUtilities.GetRSAParametersFormPublicKey(publicKey);
            switch (signType)
            {
                case "RSA2":
                    return SHA256WithRSA.Verify(data, sign, key);
                default:
                    return SHA1WithRSA.Verify(data, sign, key);
            }
        }

        public static string AESEncrypt(string data, string encyptKey)
        {
            return AES.Encrypt(data, encyptKey, AES_IV, CipherMode.CBC, PaddingMode.PKCS7);
        }

        private static byte[] InitIv(int blockSize)
        {
            var iv = new byte[blockSize];
            for (var i = 0; i < blockSize; i++)
            {
                iv[i] = 0x0;
            }

            return iv;
        }
    }
}
