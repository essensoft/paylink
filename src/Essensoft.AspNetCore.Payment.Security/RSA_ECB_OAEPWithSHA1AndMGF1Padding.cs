using System;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;

namespace Essensoft.AspNetCore.Payment.Security
{
    public static class RSA_ECB_OAEPWithSHA1AndMGF1Padding
    {
        public const string ALGORITHM = "RSA/ECB/OAEPWithSHA1AndMGF1Padding";

        public static string Encrypt(string data, ICipherParameters key)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException(nameof(data));
            }

            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var cipher = CipherUtilities.GetCipher(ALGORITHM);
            cipher.Init(true, key);
            return Convert.ToBase64String(cipher.DoFinal(Encoding.UTF8.GetBytes(data)));
        }

        public static string Decrypt(string data, ICipherParameters key)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException(nameof(data));
            }

            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var cipher = CipherUtilities.GetCipher(ALGORITHM);
            cipher.Init(false, key);
            return Encoding.UTF8.GetString(cipher.DoFinal(Convert.FromBase64String(data)));
        }
    }
}
