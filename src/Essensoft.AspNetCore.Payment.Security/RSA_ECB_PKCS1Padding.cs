using System;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;

namespace Essensoft.AspNetCore.Payment.Security
{
    public class RSA_ECB_PKCS1Padding
    {
        public static byte[] Encrypt(byte[] data, ICipherParameters key)
        {
            var cipher = CipherUtilities.GetCipher("RSA/ECB/PKCS1Padding");
            cipher.Init(true, key);
            return cipher.DoFinal(data);
        }

        public static byte[] Decrypt(byte[] data, ICipherParameters key)
        {
            var cipher = CipherUtilities.GetCipher("RSA/ECB/PKCS1Padding");
            cipher.Init(false, key);
            return cipher.DoFinal(data);
        }

        public static string Encrypt(string data, ICipherParameters key)
        {
            var cipher = CipherUtilities.GetCipher("RSA/ECB/PKCS1Padding");
            cipher.Init(true, key);
            return Convert.ToBase64String(cipher.DoFinal(Encoding.UTF8.GetBytes(data)));
        }

        public static string Decrypt(string data, ICipherParameters key)
        {
            var cipher = CipherUtilities.GetCipher("RSA/ECB/PKCS1Padding");
            cipher.Init(false, key);
            return Encoding.UTF8.GetString(cipher.DoFinal(Convert.FromBase64String(data)));
        }
    }
}
