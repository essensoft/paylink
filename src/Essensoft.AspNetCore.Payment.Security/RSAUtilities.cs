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
    public class RSAUtilities
    {
        public static ICipherParameters GetKeyParameterFormPrivateKey(string privateKey)
        {
            if (string.IsNullOrEmpty(privateKey))
            {
                throw new ArgumentNullException(nameof(privateKey));
            }

            var keyStructure = RsaPrivateKeyStructure.GetInstance(Convert.FromBase64String(privateKey));
            return new RsaPrivateCrtKeyParameters(keyStructure.Modulus, keyStructure.PublicExponent, keyStructure.PrivateExponent, keyStructure.Prime1, keyStructure.Prime2, keyStructure.Exponent1, keyStructure.Exponent2, keyStructure.Coefficient);
        }

        public static ICipherParameters GetKeyParameterFormPublicKey(string publicKey)
        {
            if (string.IsNullOrEmpty(publicKey))
            {
                throw new ArgumentNullException(nameof(publicKey));
            }

            return PublicKeyFactory.CreateKey(Convert.FromBase64String(publicKey));
        }

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
        /// -----BEGIN RSA PRIVATE KEY-----
        /// ...
        /// -----END RSA PRIVATE KEY-----
        /// </summary>
        /// <param name="privateKey"></param>
        /// <returns></returns>
        public static AsymmetricKeyParameter GetAsymmetricKeyParameterFormRsaPrivateKey(string privateKey)
        {
            if (string.IsNullOrEmpty(privateKey))
            {
                throw new ArgumentNullException(nameof(privateKey));
            }

            var key = RsaPrivateKeyStructure.GetInstance(Convert.FromBase64String(privateKey));
            return new RsaPrivateCrtKeyParameters(key.Modulus, key.PublicExponent, key.PrivateExponent, key.Prime1, key.Prime2, key.Exponent1, key.Exponent2, key.Coefficient);
        }

        /// <summary>
        /// -----BEGIN PUBLIC KEY-----
        /// ...
        /// -----END PUBLIC KEY-----
        /// </summary>
        /// <param name="publicKey"></param>
        /// <returns></returns>
        public static AsymmetricKeyParameter GetAsymmetricKeyParameterFormPublicKey(string publicKey)
        {
            if (string.IsNullOrEmpty(publicKey))
            {
                throw new ArgumentNullException(nameof(publicKey));
            }

            return PublicKeyFactory.CreateKey(Convert.FromBase64String(publicKey));
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

        public static ICipherParameters GetPublicKeyParameterFormAsn1PublicKey(string publicKey)
        {
            if (string.IsNullOrEmpty(publicKey))
            {
                throw new ArgumentNullException(nameof(publicKey));
            }

            var keyStructure = RsaPublicKeyStructure.GetInstance(Asn1Object.FromByteArray(Convert.FromBase64String(publicKey)));
            return new RsaKeyParameters(false, keyStructure.Modulus, keyStructure.PublicExponent);
        }
    }
}