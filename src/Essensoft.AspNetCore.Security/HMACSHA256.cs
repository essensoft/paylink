using System;
using System.Text;

namespace Essensoft.AspNetCore.Security
{
    public class HMACSHA256
    {
        public static string Compute(string str, string key)
        {
            using (var hmacSha256 = new System.Security.Cryptography.HMACSHA256(Encoding.UTF8.GetBytes(key)))
            {
                var hsah = hmacSha256.ComputeHash(Encoding.UTF8.GetBytes(str));
                return BitConverter.ToString(hsah).Replace("-", "");
            }
        }
    }
}
