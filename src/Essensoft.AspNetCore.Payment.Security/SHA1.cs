using System;
using System.Text;

namespace Essensoft.AspNetCore.Payment.Security
{
    public class SHA1
    {
        public static string Compute(string data)
        {
            var sha1 = System.Security.Cryptography.SHA1.Create();
            var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(data));
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }
    }
}
