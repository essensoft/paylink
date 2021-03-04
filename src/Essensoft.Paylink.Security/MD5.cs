using System;
using System.Text;

namespace Essensoft.Paylink.Security
{
    public static class MD5
    {
        public static string Compute(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException(nameof(data));
            }

            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(data));
#if NET5_0
                return Convert.ToHexString(hash);
#else
                return BitConverter.ToString(hash).Replace("-", "");
#endif
            }
        }
    }
}
