using System;
using System.Security.Cryptography;
using System.Text;

namespace Essensoft.AspNetCore.Payment.Security
{
    public static class AES
    {
        public static string Encrypt(string data, string key, byte[] iv, CipherMode cipherMode, PaddingMode paddingMode)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException(nameof(data));
            }

            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (iv == null)
            {
                throw new ArgumentNullException(nameof(iv));
            }

            using (var aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                aes.Mode = cipherMode;
                aes.Padding = paddingMode;

                using (var ctf = aes.CreateEncryptor())
                {
                    var content = Encoding.UTF8.GetBytes(data);
                    return Convert.ToBase64String(ctf.TransformFinalBlock(content, 0, content.Length));
                }
            }
        }

        public static string Decrypt(string data, string key, byte[] iv, CipherMode cipherMode, PaddingMode paddingMode)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException(nameof(data));
            }

            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (iv == null)
            {
                throw new ArgumentNullException(nameof(iv));
            }

            using (var aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                aes.Mode = cipherMode;
                aes.Padding = paddingMode;

                using (var ctf = aes.CreateDecryptor())
                {
                    var content = Convert.FromBase64String(data);
                    return Encoding.UTF8.GetString(ctf.TransformFinalBlock(content, 0, content.Length));
                }
            }
        }

        public static string Encrypt(string data, string key, CipherMode cipherMode, PaddingMode paddingMode)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException(nameof(data));
            }

            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException(nameof(key));
            }

            using (var aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.Mode = cipherMode;
                aes.Padding = paddingMode;

                using (var ctf = aes.CreateEncryptor())
                {
                    var content = Encoding.UTF8.GetBytes(data);
                    return Convert.ToBase64String(ctf.TransformFinalBlock(content, 0, content.Length));
                }
            }
        }

        public static string Decrypt(string data, string key, CipherMode cipherMode, PaddingMode paddingMode)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException(nameof(data));
            }

            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException(nameof(key));
            }

            using (var aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.Mode = cipherMode;
                aes.Padding = paddingMode;

                using (var ctf = aes.CreateDecryptor())
                {
                    var content = Convert.FromBase64String(data);
                    return Encoding.UTF8.GetString(ctf.TransformFinalBlock(content, 0, content.Length));
                }
            }
        }
    }
}
