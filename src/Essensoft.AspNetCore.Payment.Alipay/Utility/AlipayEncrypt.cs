using System;
using System.Security.Cryptography;
using System.Text;
namespace Essensoft.AspNetCore.Payment.Alipay.Utility
{
    internal class AlipayEncrypt
    {
        /// <summary>
        /// 128位0向量
        /// </summary>
        private static readonly byte[] AES_IV = InitIv(16);

        /// <summary>
        /// AES 加密
        /// </summary>
        /// <param name="encryptKey"></param>
        /// <param name="bizContent"></param>
        /// <param name="charset"></param>
        /// <returns></returns>
        public static string AesEncrypt(string encryptKey, string bizContent)
        {
            var keyArray = Convert.FromBase64String(encryptKey);
            var toEncryptArray = Encoding.UTF8.GetBytes(bizContent);

            var rDel = Aes.Create();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.CBC;
            rDel.Padding = PaddingMode.PKCS7;
            rDel.IV = AES_IV;

            var cTransform = rDel.CreateEncryptor(rDel.Key, rDel.IV);
            var resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray);
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="encryptKey"></param>
        /// <param name="bizContent"></param>
        /// <param name="charset"></param>
        /// <returns></returns>
        public static string AesDencrypt(string encryptKey, string bizContent)
        {
            var keyArray = Convert.FromBase64String(encryptKey);
            var toEncryptArray = Convert.FromBase64String(bizContent);

            var rDel = Aes.Create();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.CBC;
            rDel.Padding = PaddingMode.PKCS7;
            rDel.IV = AES_IV;

            var cTransform = rDel.CreateDecryptor(rDel.Key, rDel.IV);
            var resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Encoding.UTF8.GetString(resultArray);
        }

        /// <summary>
        ///     初始化向量
        /// </summary>
        /// <param name="blockSize"></param>
        /// <returns></returns>
        private static byte[] InitIv(int blockSize)
        {
            var iv = new byte[blockSize];
            for (var i = 0; i < blockSize; i++)
                iv[i] = 0x0;
            return iv;
        }
    }

}
