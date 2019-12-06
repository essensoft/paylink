using System;
using System.Security.Cryptography;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Essensoft.AspNetCore.Payment.Security
{
    public static class RSAUtilities
    {
        /// <summary>
        /// -----BEGIN RSA PRIVATE KEY-----
        /// ...
        /// -----END RSA PRIVATE KEY-----
        /// </summary>
        /// <param name="privateKey"></param>
        /// <returns></returns>
        public static RSAParameters GetRSAParametersFormRsaPrivateKey(string privateKey)
        {
            if (string.IsNullOrEmpty(privateKey))
            {
                throw new ArgumentNullException(nameof(privateKey));
            }

            var key = RsaPrivateKeyStructure.GetInstance(Convert.FromBase64String(privateKey));
            return new RSAParameters
            {
                D = key.PrivateExponent.ToByteArrayUnsigned(),
                DP = key.Exponent1.ToByteArrayUnsigned(),
                DQ = key.Exponent2.ToByteArrayUnsigned(),
                Exponent = key.PublicExponent.ToByteArrayUnsigned(),
                InverseQ = key.Coefficient.ToByteArrayUnsigned(),
                Modulus = key.Modulus.ToByteArrayUnsigned(),
                P = key.Prime1.ToByteArrayUnsigned(),
                Q = key.Prime2.ToByteArrayUnsigned(),
            };
        }

        /// <summary>
        /// -----BEGIN PUBLIC KEY-----
        /// ...
        /// -----END PUBLIC KEY-----
        /// </summary>
        /// <param name="publicKey"></param>
        /// <returns></returns>
        public static RSAParameters GetRSAParametersFormPublicKey(string publicKey)
        {
            if (string.IsNullOrEmpty(publicKey))
            {
                throw new ArgumentNullException(nameof(publicKey));
            }

            var key = (RsaKeyParameters)PublicKeyFactory.CreateKey(Convert.FromBase64String(publicKey));
            return new RSAParameters
            {
                Modulus = key.Modulus.ToByteArrayUnsigned(),
                Exponent = key.Exponent.ToByteArrayUnsigned()
            };
        }

        /// <summary>
        /// -----BEGIN RSA PUBLIC KEY-----
        /// ...
        /// -----END RSA PUBLIC KEY-----
        /// </summary>
        /// <param name="publicKey"></param>
        /// <returns></returns>
        public static AsymmetricKeyParameter GetAsymmetricKeyParameterFormRsaPublicKey(string publicKey)
        {
            if (string.IsNullOrEmpty(publicKey))
            {
                throw new ArgumentNullException(nameof(publicKey));
            }

            var key = RsaPublicKeyStructure.GetInstance(Asn1Object.FromByteArray(Convert.FromBase64String(publicKey)));
            return new RsaKeyParameters(false, key.Modulus, key.PublicExponent);
        }
    }
}