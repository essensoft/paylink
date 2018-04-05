using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Utility
{
    public class LianLianPaySignature
    {
        public static string GetSignContent(LianLianPayDictionary para, IList<string> excludePara = null)
        {
            if (para == null || para.Count == 0)
                return string.Empty;

            var sb = new StringBuilder();
            foreach (var iter in para)
            {
                if (excludePara != null && excludePara.Contains(iter.Key))
                {
                    continue;
                }

                if (!string.IsNullOrEmpty(iter.Value) && "sign" != iter.Key)
                {
                    sb.Append(iter.Key).Append("=").Append(iter.Value).Append("&");
                }
            }

            return sb.Remove(sb.Length - 1, 1).ToString();
        }

        public static string RSASignContent(string data, RSAParameters parameters)
        {
            var rsa = RSA.Create();
            rsa.ImportParameters(parameters);
            return Convert.ToBase64String(rsa.SignData(Encoding.UTF8.GetBytes(data), HashAlgorithmName.MD5, RSASignaturePadding.Pkcs1));
        }

        public static bool RSACheckContent(string signContent, string sign, RSAParameters parameters)
        {
            try
            {
                var rsa = RSA.Create();
                rsa.ImportParameters(parameters);
                return rsa.VerifyData(Encoding.UTF8.GetBytes(signContent), Convert.FromBase64String(sign), HashAlgorithmName.MD5, RSASignaturePadding.Pkcs1);
            }
            catch
            {
                return false;
            }
        }

        public static RSAParameters GetPrivateParameters(string privateKey)
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

        public static RSAParameters GetPublicParameters(string publicKey)
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
