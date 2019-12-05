using System;
using System.Security.Cryptography;
using System.Text;

namespace Essensoft.AspNetCore.Payment.Security
{
    public static class SHA1WithRSA
    {
        public static string Sign(string data, RSAParameters privateKey)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException(nameof(data));
            }

            using (var rsa = RSA.Create())
            {
                rsa.ImportParameters(privateKey);
                return Convert.ToBase64String(rsa.SignData(Encoding.UTF8.GetBytes(data), HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1));
            }
        }

        public static bool Verify(string data, string sign, RSAParameters publicKey)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException(nameof(data));
            }

            if (string.IsNullOrEmpty(sign))
            {
                throw new ArgumentNullException(nameof(sign));
            }

            using (var rsa = RSA.Create())
            {
                rsa.ImportParameters(publicKey);
                return rsa.VerifyData(Encoding.UTF8.GetBytes(data), Convert.FromBase64String(sign), HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);
            }
        }
    }
}
