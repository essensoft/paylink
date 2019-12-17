using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;

namespace Essensoft.AspNetCore.Payment.Security
{
    public static class RSAUtilities
    {
        /// <summary>
        /// -----BEGIN RSA PUBLIC KEY-----
        /// ...
        /// -----END RSA PUBLIC KEY-----
        /// </summary>
        /// <param name="publicKey"></param>
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