using System;
using System.Text;

namespace Essensoft.AspNetCore.Payment.Security
{
    public class HMACSHA256
    {
        public static string Compute(string data, string key)
        {
            using (var hmacSha256 = new System.Security.Cryptography.HMACSHA256(Encoding.UTF8.GetBytes(key)))
            {
                var hsah = hmacSha256.ComputeHash(Encoding.UTF8.GetBytes(data));
                return BitConverter.ToString(hsah).Replace("-", "");
            }
        }

        public static byte[] Compute(byte[] data, byte[] key)
        {
            using (var hmacSha256 = new System.Security.Cryptography.HMACSHA256(key))
            {
                return hmacSha256.ComputeHash(data);
            }
        }
    }
}
