using System.IO;
using System.Security.Cryptography;

namespace Essensoft.AspNetCore.Payment.Security
{
    public enum DESCipherMode
    {
        CBC = CipherMode.CBC,
        ECB = CipherMode.ECB
    }

    public enum DESPaddingMode
    {
        PKCS7 = PaddingMode.PKCS7,
        Zeros = PaddingMode.Zeros
    }

    public class DES3
    {
        public static byte[] Encode(byte[] data, byte[] key, byte[] iv, DESCipherMode cipherMode, DESPaddingMode paddingMode)
        {
            try
            {
                var tdsp = new TripleDESCryptoServiceProvider
                {
                    Mode = (CipherMode)cipherMode,
                    Padding = (PaddingMode)paddingMode
                };
                using (var stream = new MemoryStream())
                using (var crypto = new CryptoStream(stream, tdsp.CreateEncryptor(key, iv), CryptoStreamMode.Write))
                {
                    crypto.Write(data, 0, data.Length);
                    crypto.FlushFinalBlock();
                    return stream.ToArray();
                }
            }
            catch
            {
                return null;
            }
        }

        public static byte[] Decode(byte[] data, byte[] key, byte[] iv, DESCipherMode cipherMode, DESPaddingMode paddingMode)
        {
            try
            {
                var tdsp = new TripleDESCryptoServiceProvider
                {
                    Mode = (CipherMode)cipherMode,
                    Padding = (PaddingMode)paddingMode
                };
                using (var stream = new MemoryStream(data))
                using (var crypto = new CryptoStream(stream, tdsp.CreateDecryptor(key, iv), CryptoStreamMode.Read))
                {
                    var fromEncrypt = new byte[data.Length];
                    crypto.Read(fromEncrypt, 0, fromEncrypt.Length);
                    return fromEncrypt;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
