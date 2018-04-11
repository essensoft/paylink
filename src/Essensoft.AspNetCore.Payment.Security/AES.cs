using System;
using System.Security.Cryptography;
using System.Text;

namespace Essensoft.AspNetCore.Payment.Security
{
    public enum AESCipherModeMode
    {
        CBC = CipherMode.CBC,
        ECB = CipherMode.ECB,
        OFB = CipherMode.OFB,
        CFB = CipherMode.CFB,
        CTS = CipherMode.CTS
    }

    public enum AESPaddingMode
    {
        None = PaddingMode.None,
        PKCS7 = PaddingMode.PKCS7,
        Zeros = PaddingMode.Zeros,
        ANSIX923 = PaddingMode.ANSIX923,
        ISO10126 = PaddingMode.ISO10126
    }

    public class AES
    {
        public static readonly byte[] ALIPAY_AES_IV = InitIv(16);

        public static string Encrypt(string data, string key, AESPaddingMode paddingMode, AESCipherModeMode cipherMode, byte[] iv)
        {
            var rm = new RijndaelManaged
            {
                IV = iv,
                Key = Encoding.UTF8.GetBytes(key),
                Mode = (CipherMode)cipherMode,
                Padding = (PaddingMode)paddingMode,
            };

            var content = Encoding.UTF8.GetBytes(data);
            var ctf = rm.CreateEncryptor();
            return Convert.ToBase64String(ctf.TransformFinalBlock(content, 0, content.Length));
        }

        public static string Decrypt(string data, string key, AESPaddingMode paddingMode, AESCipherModeMode cipherMode, byte[] iv)
        {
            var rm = new RijndaelManaged
            {
                IV = iv,
                Key = Encoding.UTF8.GetBytes(key),
                Mode = (CipherMode)cipherMode,
                Padding = (PaddingMode)paddingMode,
            };

            var content = Convert.FromBase64String(data);
            var ctf = rm.CreateDecryptor();
            return Encoding.UTF8.GetString(ctf.TransformFinalBlock(content, 0, content.Length));
        }

        public static string Encrypt(string data, string key, AESPaddingMode paddingMode, AESCipherModeMode cipherMode)
        {
            var rm = new RijndaelManaged
            {
                Key = Encoding.UTF8.GetBytes(key),
                Mode = (CipherMode)cipherMode,
                Padding = (PaddingMode)paddingMode,
            };

            var content = Encoding.UTF8.GetBytes(data);
            var ctf = rm.CreateEncryptor();
            return Convert.ToBase64String(ctf.TransformFinalBlock(content, 0, content.Length));
        }

        public static string Decrypt(string data, string key, AESPaddingMode paddingMode, AESCipherModeMode cipherMode)
        {
            var rm = new RijndaelManaged
            {
                Key = Encoding.UTF8.GetBytes(key),
                Mode = (CipherMode)cipherMode,
                Padding = (PaddingMode)paddingMode,
            };

            var content = Convert.FromBase64String(data);
            var ctf = rm.CreateDecryptor();
            return Encoding.UTF8.GetString(ctf.TransformFinalBlock(content, 0, content.Length));
        }

        private static byte[] InitIv(int blockSize)
        {
            var iv = new byte[blockSize];
            for (var i = 0; i < blockSize; i++)
                iv[i] = 0x0;
            return iv;
        }
    }
}
