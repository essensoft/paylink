using System;
using System.Text;

namespace Essensoft.AspNetCore.Security
{
    public class SHA256
    {
        public static string Compute(string strSrc)
        {
            var sourceByte = Encoding.UTF8.GetBytes(strSrc);
            var sha256 = System.Security.Cryptography.SHA256.Create();
            var cryByte = sha256.ComputeHash(sourceByte);
            return BitConverter.ToString(cryByte).Replace("-", "").ToLower();
        }
    }
}
