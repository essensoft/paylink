using Essensoft.AspNetCore.Security;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace Essensoft.AspNetCore.WeChatPay.Utility
{
    public class WeChatPaySignature
    {
        public static string SignWithKey(SortedDictionary<string, string> parameters, string key, bool useMD5 = true, bool excludeSignType = true)
        {
            var sb = new StringBuilder();
            foreach (var iter in parameters)
            {
                if (!string.IsNullOrEmpty(iter.Value) && iter.Key != "sign" && (excludeSignType ? iter.Key != "sign_type" : true))
                    sb.Append(iter.Key).Append('=').Append(iter.Value).Append("&");
            }
            var signContent = sb.Append("key=").Append(key).ToString();
            return useMD5 ? MD5.Compute(signContent).ToUpper() : HMACSHA256.Compute(signContent, key).ToUpper();
        }

        public static string Encrypt(string data, object parameters)
        {
            var cipher = (BufferedAsymmetricBlockCipher)CipherUtilities.GetCipher("RSA/ECB/OAEPWITHSHA-1ANDMGF1PADDING");
            cipher.Init(true, parameters as ICipherParameters);
            var outBytes = cipher.DoFinal(Encoding.UTF8.GetBytes(data));
            return Convert.ToBase64String(outBytes);
        }

        public static ICipherParameters GetPublicKeyParameters(string publicKey)
        {
            var rsaPubStructure = RsaPublicKeyStructure.GetInstance(Asn1Object.FromByteArray(Convert.FromBase64String(publicKey)));
            return new RsaKeyParameters(false, rsaPubStructure.Modulus, rsaPubStructure.PublicExponent);
        }
    }
}
