using System;
using System.Security.Cryptography;
using System.Text;

namespace Essensoft.AspNetCore.Payment.Security
{
    public static class OaepSHA1WithRSA
    {
        public static string Encrypt(string data, string publicKey)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException(nameof(data));
            }

            if (string.IsNullOrEmpty(publicKey))
            {
                throw new ArgumentNullException(nameof(publicKey));
            }

            using (var rsa = RSA.Create())
            {
                rsa.ImportRSAPublicKey(Convert.FromBase64String(publicKey), out var _);
                return Convert.ToBase64String(rsa.Encrypt(Encoding.UTF8.GetBytes(data), RSAEncryptionPadding.OaepSHA1));
            }
        }

        public static string Decrypt(string data, string privateKey)
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
                return Encoding.UTF8.GetString(rsa.Decrypt(Convert.FromBase64String(data), RSAEncryptionPadding.OaepSHA1));
            }
        }
    }
}
