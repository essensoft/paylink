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
            var keyStructure = RsaPrivateKeyStructure.GetInstance(Convert.FromBase64String(privateKey));
            return new RsaPrivateCrtKeyParameters(keyStructure.Modulus, keyStructure.PublicExponent, keyStructure.PrivateExponent, keyStructure.Prime1, keyStructure.Prime2, keyStructure.Exponent1, keyStructure.Exponent2, keyStructure.Coefficient);
        }

        public static ICipherParameters GetKeyParameterFormPublicKey(string publicKey)
        {
            return PublicKeyFactory.CreateKey(Convert.FromBase64String(publicKey));
        }

        public static RSAParameters GetRSAParametersFormPrivateKey(string privateKey)
        {
            var keyStructure = RsaPrivateKeyStructure.GetInstance(Convert.FromBase64String(privateKey));
            return new RSAParameters
            {
                Modulus = keyStructure.Modulus.ToByteArrayUnsigned(),
                Exponent = keyStructure.PublicExponent.ToByteArrayUnsigned(),
                D = keyStructure.PrivateExponent.ToByteArrayUnsigned(),
                P = keyStructure.Prime1.ToByteArrayUnsigned(),
                Q = keyStructure.Prime2.ToByteArrayUnsigned(),
                DP = keyStructure.Exponent1.ToByteArrayUnsigned(),
                DQ = keyStructure.Exponent2.ToByteArrayUnsigned(),
                InverseQ = keyStructure.Coefficient.ToByteArrayUnsigned()
            };
        }

        public static RSAParameters GetRSAParametersFormPublicKey(string publicKey)
        {
            var key = (RsaKeyParameters)PublicKeyFactory.CreateKey(Convert.FromBase64String(publicKey));
            return new RSAParameters
            {
                Modulus = key.Modulus.ToByteArrayUnsigned(),
                Exponent = key.Exponent.ToByteArrayUnsigned()
            };
        }

        public static ICipherParameters GetPublicKeyParameterFormAsn1PublicKey(string publicKey)
        {
            var keyStructure = RsaPublicKeyStructure.GetInstance(Asn1Object.FromByteArray(Convert.FromBase64String(publicKey)));
            return new RsaKeyParameters(false, keyStructure.Modulus, keyStructure.PublicExponent);
        }
    }
}
