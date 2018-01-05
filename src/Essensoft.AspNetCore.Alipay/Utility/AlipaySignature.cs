using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Essensoft.AspNetCore.Security.Asn1.Pkcs;
using Essensoft.AspNetCore.Security.Crypto.Parameters;
using Essensoft.AspNetCore.Security.Security;

namespace Essensoft.AspNetCore.Alipay.Utility
{
    public class AlipaySignature
    {
        public static string GetSignContent(IDictionary<string, string> parameters)
        {
            // 第一步：把字典按Key的字母顺序排序
            IDictionary<string, string> sortedParams = new SortedDictionary<string, string>(parameters);

            // 第二步：把所有参数名和参数值串在一起
            var content = new StringBuilder();
            foreach (var iter in sortedParams)
            {
                if (!string.IsNullOrEmpty(iter.Value))
                {
                    content.Append(iter.Key + "=" + iter.Value + "&");
                }
            }
            return content.ToString().Substring(0, content.Length - 1);
        }

        public static string RSASignContent(string data, string privateKey, string signType)
        {
            var rsa = RSA.Create();
            rsa.ImportParameters(GetPrivateParameters(privateKey));
            return Convert.ToBase64String(rsa.SignData(Encoding.UTF8.GetBytes(data), "RSA2" == signType ? HashAlgorithmName.SHA256 : HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1));
        }

        public static string RSASign(IDictionary<string, string> parameters, string privateKey, string signType)
        {
            var signContent = GetSignContent(parameters);

            return RSASignContent(signContent, privateKey, signType);
        }

        public static bool RSACheckContent(string signContent, string sign, string publicKey, string signType)
        {
            try
            {
                var rsa = RSA.Create();
                rsa.ImportParameters(GetPublicParameters(publicKey));
                return rsa.VerifyData(Encoding.UTF8.GetBytes(signContent), Convert.FromBase64String(sign), "RSA2" == signType ? HashAlgorithmName.SHA256 : HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);
            }
            catch
            {
                return false;
            }
        }

        private static RSAParameters GetPrivateParameters(string privateKey)
        {
            var key = RsaPrivateKeyStructure.GetInstance(Convert.FromBase64String(privateKey));
            return new RSAParameters
            {
                Modulus = key.Modulus.ToByteArrayUnsigned(),
                Exponent = key.PublicExponent.ToByteArrayUnsigned(),
                D = key.PrivateExponent.ToByteArrayUnsigned(),
                P = key.Prime1.ToByteArrayUnsigned(),
                Q = key.Prime2.ToByteArrayUnsigned(),
                DP = key.Exponent1.ToByteArrayUnsigned(),
                DQ = key.Exponent2.ToByteArrayUnsigned(),
                InverseQ = key.Coefficient.ToByteArrayUnsigned(),
            };
        }

        private static RSAParameters GetPublicParameters(string publicKey)
        {
            var key = (RsaKeyParameters)PublicKeyFactory.CreateKey(Convert.FromBase64String(publicKey));
            return new RSAParameters
            {
                Modulus = key.Modulus.ToByteArrayUnsigned(),
                Exponent = key.Exponent.ToByteArrayUnsigned(),
            };
        }
    }
}
