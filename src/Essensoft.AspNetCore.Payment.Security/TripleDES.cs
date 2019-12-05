using System;
using System.Security.Cryptography;

namespace Essensoft.AspNetCore.Payment.Security
{
    public static class TripleDES
    {
        public static byte[] Encode(byte[] data, byte[] key, byte[] iv, CipherMode cipherMode, PaddingMode paddingMode)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (iv == null)
            {
                throw new ArgumentNullException(nameof(iv));
            }

            using (var des = System.Security.Cryptography.TripleDES.Create())
            {
                des.Key = key;
                des.IV = iv;
                des.Mode = cipherMode;
                des.Padding = paddingMode;

                using (var ctf = des.CreateEncryptor())
                {
                    return ctf.TransformFinalBlock(data, 0, data.Length);
                }
            }
        }

        public static byte[] Decode(byte[] data, byte[] key, byte[] iv, CipherMode cipherMode, PaddingMode paddingMode)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (iv == null)
            {
                throw new ArgumentNullException(nameof(iv));
            }

            using (var des = System.Security.Cryptography.TripleDES.Create())
            {
                des.Key = key;
                des.IV = iv;
                des.Mode = cipherMode;
                des.Padding = paddingMode;

                using (var ctf = des.CreateDecryptor())
                {
                    return ctf.TransformFinalBlock(data, 0, data.Length);
                }
            }
        }
    }
}
