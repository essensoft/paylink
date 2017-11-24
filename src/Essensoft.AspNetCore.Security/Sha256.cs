using System.Security.Cryptography;
using System.Text;

namespace Essensoft.AspNetCore.Security
{
    public class Sha256
    {
        public static string Encrypt(string strSrc)
        {
            var sourceByte = Encoding.UTF8.GetBytes(strSrc);
            var sha256 = SHA256.Create();
            var cryByte = sha256.ComputeHash(sourceByte);
            return ByteToHexStr(cryByte);
        }

        //将数组转换成16进制字符串
        private static string ByteToHexStr(byte[] bytes)
        {
            var returnStr = string.Empty;
            if (bytes != null)
            {
                for (var i = 0; i < bytes.Length; i++)
                {
                    returnStr += bytes[i].ToString("X2");
                }
            }
            return returnStr.ToLower();
        }
    }
}
