using System;
using System.Text;

namespace Essensoft.AspNetCore.Security
{
    public class SHA1
    {
        public static string Compute(string strSrc)
        {
            var sourceByte = Encoding.UTF8.GetBytes(strSrc);
            var sha1 = System.Security.Cryptography.SHA1.Create();
            var cryByte = sha1.ComputeHash(sourceByte);
            return BitConverter.ToString(cryByte).Replace("-", "").ToLower();
        }
    }
}
