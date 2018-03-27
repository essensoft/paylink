using System;
using System.Security.Cryptography;
using System.Text;

namespace Essensoft.AspNetCore.Security
{
    /// <summary>
    /// AES加密解密
    /// </summary>
    public class AES
    {
        /// <summary>
        ///  AES 加密
        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Encrypt(string data, string key)
        {
            var rm = new RijndaelManaged
            {
                Key = Encoding.UTF8.GetBytes(key),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            var content = Encoding.UTF8.GetBytes(data);
            var cTransform = rm.CreateEncryptor();
            return Convert.ToBase64String(cTransform.TransformFinalBlock(content, 0, content.Length));
        }

        /// <summary>
        ///  AES 解密
        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Decrypt(string data, string key)
        {
            var rm = new RijndaelManaged
            {
                Key = Encoding.UTF8.GetBytes(key),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            var content = Convert.FromBase64String(data);
            var cTransform = rm.CreateDecryptor();
            return Encoding.UTF8.GetString(cTransform.TransformFinalBlock(content, 0, content.Length));
        }
    }
}
