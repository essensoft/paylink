using System;
using System.Text;
using Essensoft.AspNetCore.Security.Asn1;
using Essensoft.AspNetCore.Security.Asn1.X509;
using Essensoft.AspNetCore.Security.Crypto;
using Essensoft.AspNetCore.Security.Crypto.Parameters;
using Essensoft.AspNetCore.Security.Security;

namespace Essensoft.AspNetCore.WeChatPay.Utility
{
    public class WeChatPaySignature
    {
        public static string Encrypt(string data, string publicKey)
        {
            var key = GetPublicKeyParameters(publicKey);

            var cipher = (BufferedAsymmetricBlockCipher)CipherUtilities.GetCipher("RSA/ECB/OAEPWITHSHA-1ANDMGF1PADDING");
            cipher.Init(true, key);
            var outBytes = cipher.DoFinal(Encoding.UTF8.GetBytes(data));
            return Convert.ToBase64String(outBytes);
        }

        private static ICipherParameters GetPublicKeyParameters(string publicKey)
        {
            var rsaPubStructure = RsaPublicKeyStructure.GetInstance(Asn1Object.FromByteArray(Convert.FromBase64String(publicKey)));
            return new RsaKeyParameters(false, rsaPubStructure.Modulus, rsaPubStructure.PublicExponent);
        }
    }
}
