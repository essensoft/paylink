using System;
using System.Text;
using Essensoft.AspNetCore.Security;
using Essensoft.AspNetCore.Security.Asn1.Pkcs;
using Essensoft.AspNetCore.Security.Parameters;
using Essensoft.AspNetCore.Security.Security;

namespace Essensoft.AspNetCore.JdPay.Utility
{
    public class JdPaySignature
    {
        public static byte[] Encrypt(string data, string privateKey)
        {
            var key = GetPrivateKeyParameters(privateKey);

            var cipher = CipherUtilities.GetCipher("RSA/ECB/PKCS1Padding");
            cipher.Init(true, key);
            return cipher.DoFinal(Encoding.UTF8.GetBytes(data));
        }

        public static byte[] Decrypt(string data, string publicKey)
        {
            var key = GetPublicKeyParameters(publicKey);

            var cipher = CipherUtilities.GetCipher("RSA/ECB/PKCS1Padding");
            cipher.Init(false, key);
            return cipher.DoFinal(Convert.FromBase64String(data));
        }

        private static ICipherParameters GetPrivateKeyParameters(string privateKey)
        {
            var rsaPrivStructure = RsaPrivateKeyStructure.GetInstance(Convert.FromBase64String(privateKey));
            return new RsaPrivateCrtKeyParameters(rsaPrivStructure.Modulus, rsaPrivStructure.PublicExponent, rsaPrivStructure.PrivateExponent,
                rsaPrivStructure.Prime1, rsaPrivStructure.Prime2, rsaPrivStructure.Exponent1, rsaPrivStructure.Exponent2, rsaPrivStructure.Coefficient);
        }

        private static ICipherParameters GetPublicKeyParameters(string publicKey)
        {
            return PublicKeyFactory.CreateKey(Convert.FromBase64String(publicKey));
        }
    }
}
