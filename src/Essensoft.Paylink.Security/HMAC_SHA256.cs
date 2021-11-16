using System;
using System.Text;

namespace Essensoft.Paylink.Security
{
    public static class HMAC_SHA256
    {
        public static string Compute(string data, string key)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException(nameof(data));
            }

            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException(nameof(key));
            }

            using (var hmacSha256 = new System.Security.Cryptography.HMACSHA256(Encoding.UTF8.GetBytes(key)))
            {
                var hash = hmacSha256.ComputeHash(Encoding.UTF8.GetBytes(data));
#if NET5_0_OR_GREATER
                return Convert.ToHexString(hash);
#else
                return BitConverter.ToString(hash).Replace("-", "");
#endif
            }
        }
    }
}
