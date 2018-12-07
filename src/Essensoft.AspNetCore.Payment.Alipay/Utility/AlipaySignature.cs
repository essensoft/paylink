using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Essensoft.AspNetCore.Payment.Alipay.Utility
{
    /// <summary>
    /// Alipay «©√˚¿‡°£
    /// </summary>
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

        public static string RSASignContent(string data, RSAParameters parameters, string signType)
        {
            using (var rsa = RSA.Create())
            {
                rsa.ImportParameters(parameters);
                var type = "RSA2" == signType ? HashAlgorithmName.SHA256 : HashAlgorithmName.SHA1;
                return Convert.ToBase64String(rsa.SignData(Encoding.UTF8.GetBytes(data), type, RSASignaturePadding.Pkcs1));
            }
        }

        public static bool RSACheckContent(string data, string sign, RSAParameters parameters, string signType)
        {
            using (var rsa = RSA.Create())
            {
                var type = "RSA2" == signType ? HashAlgorithmName.SHA256 : HashAlgorithmName.SHA1;
                rsa.ImportParameters(parameters);
                return rsa.VerifyData(Encoding.UTF8.GetBytes(data), Convert.FromBase64String(sign), type, RSASignaturePadding.Pkcs1);
            }
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
