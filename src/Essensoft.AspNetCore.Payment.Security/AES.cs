using System;
using System.Security.Cryptography;
using System.Text;

namespace Essensoft.AspNetCore.Payment.Security
{
    public enum AESCipherMode
    {
        CBC = CipherMode.CBC,
        ECB = CipherMode.ECB,
    }

    public enum AESPaddingMode
    {
        PKCS7 = PaddingMode.PKCS7,
    }

    public class AES
    {
        public static string Encrypt(string data, string key, byte[] iv, AESCipherMode cipherMode, AESPaddingMode paddingMode)
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

        public static string Decrypt(string data, string key, byte[] iv, AESCipherMode cipherMode, AESPaddingMode paddingMode)
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

        public static string Encrypt(string data, string key, AESCipherMode cipherMode, AESPaddingMode paddingMode)
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

        public static string Decrypt(string data, string key, AESCipherMode cipherMode, AESPaddingMode paddingMode)
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
    }
}
