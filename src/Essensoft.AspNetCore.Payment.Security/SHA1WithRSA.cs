using System;
using System.Security.Cryptography;
using System.Text;

namespace Essensoft.AspNetCore.Payment.Security
{
    public static class SHA1WithRSA
    {
        public static string Sign(string data, string privateKey)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException(nameof(data));
            }

            if (string.IsNullOrEmpty(privateKey))
            {
                throw new ArgumentNullException(nameof(privateKey));
            }

            using (var rsa = RSA.Create())
            {
                rsa.ImportRSAPrivateKey(Convert.FromBase64String(privateKey), out var _);
                return Convert.ToBase64String(rsa.SignData(Encoding.UTF8.GetBytes(data), HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1));
            }
        }

        public static bool Verify(string data, string sign, string publicKey)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException(nameof(data));
            }

            if (string.IsNullOrEmpty(sign))
            {
                throw new ArgumentNullException(nameof(sign));
            }

            if (string.IsNullOrEmpty(publicKey))
            {
                throw new ArgumentNullException(nameof(publicKey));
            }

            using (var rsa = RSA.Create())
            {
                rsa.ImportSubjectPublicKeyInfo(Convert.FromBase64String(publicKey), out var _);
                return rsa.VerifyData(Encoding.UTF8.GetBytes(data), Convert.FromBase64String(sign), HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);
            }
        }
    }
}
