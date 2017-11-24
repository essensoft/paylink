using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Essensoft.AspNetCore.Security
{
    /// <summary>
    /// DES3加密解密
    /// </summary>
    public class Des3
    {
        private const int MAX_MSG_LENGTH = 16 * 1024;
        private static byte[] iv = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

        public static string Des3EncryptECB(byte[] key, string data)
        {
            var resultByte = InitResultByteArray(data);
            var desdata = Des3EncodeECB(key, iv, resultByte);
            return ByteToHexStr(desdata);
        }

        public static string Des3DecryptECB(byte[] key, string data)
        {
            var hexSourceData = Hex2byte(data);
            var unDesResult = Des3DecodeECB(key, iv, hexSourceData);
            var dataSizeByte = new byte[4];
            dataSizeByte[0] = unDesResult[0];
            dataSizeByte[1] = unDesResult[1];
            dataSizeByte[2] = unDesResult[2];
            dataSizeByte[3] = unDesResult[3];
            var dsb = ByteArrayToInt(dataSizeByte, 0);
            if (dsb > MAX_MSG_LENGTH)
            {
                throw new Exception("msg over MAX_MSG_LENGTH or msg error");
            }
            var tempData = new byte[dsb];
            for (var i = 0; i < dsb; i++)
            {
                tempData[i] = unDesResult[4 + i];
            }
            var hexStr = ByteToHexStr(tempData);
            var str = Hex2bin(hexStr);
            return str;
        }

        public static string Des3EncryptCBC(byte[] key, string data)
        {
            var desdata = Des3EncodeCBC(key, iv, Encoding.UTF8.GetBytes(data));
            return ByteToHexStr(desdata);
        }

        public static string Des3DecryptCBC(byte[] key, string data)
        {
            var desdata = Des3DecodeCBC(key, iv, Encoding.UTF8.GetBytes(data));
            return Encoding.UTF8.GetString(desdata);
        }

        public static byte[] InitResultByteArray(string data)
        {
            var source = Encoding.UTF8.GetBytes(data);
            var merchantData = source.Length;
            var x = (merchantData + 4) % 8;
            var y = (x == 0) ? 0 : (8 - x);
            var resultByte = new byte[merchantData + 4 + y];
            resultByte[0] = (byte)((merchantData >> 24) & 0xFF);
            resultByte[1] = (byte)((merchantData >> 16) & 0xFF);
            resultByte[2] = (byte)((merchantData >> 8) & 0xFF);
            resultByte[3] = (byte)(merchantData & 0xFF);
            //4.填充补位数据
            for (var i = 0; i < merchantData; i++)
            {
                resultByte[4 + i] = source[i];
            }
            for (var i = 0; i < y; i++)
            {
                resultByte[merchantData + 4 + i] = 0x00;
            }

            return resultByte;
        }

        public static byte[] Hex2byte(string b)
        {
            if ((b.Length % 2) != 0)
            {
                throw new Exception("长度不是偶数");
            }
            var b2 = new byte[b.Length / 2];
            for (var n = 0; n < b.Length; n += 2)
            {
                var item = b.Substring(n, 2);
                // 两位一组，表示一个字节,把这样表示的16进制字符串，还原成一个进制字节
                b2[n / 2] = (byte)Convert.ToInt32(item, 16);
            }
            b = null;
            return b2;
        }

        public static int ByteArrayToInt(byte[] b, int offset)
        {
            var value = 0;
            for (var i = 0; i < 4; i++)
            {
                var shift = (4 - 1 - i) * 8;
                value += (b[i + offset] & 0x000000FF) << shift;//往高位游
            }
            return value;
        }

        public static string Hex2bin(string hex)
        {
            var digital = "0123456789abcdef";
            var hex2char = hex.ToCharArray();
            var bytes = new byte[hex.Length / 2];
            int temp;
            for (var i = 0; i < bytes.Length; i++)
            {
                temp = digital.IndexOf(hex2char[2 * i]) * 16;
                temp += digital.IndexOf(hex2char[2 * i + 1]);
                bytes[i] = (byte)(temp & 0xff);
            }

            return Encoding.UTF8.GetString(bytes);
        }

        public static string BytesToString(byte[] src)
        {
            var hexstring = "0123456789ABCDEF";
            var stringBuilder = new StringBuilder("");
            if (src == null || src.Length <= 0)
            {
                return null;
            }
            for (var i = 0; i < src.Length; i++)
            {
                var v = src[i] & 0xFF;
                var hv = Convert.ToString(v, 16);
                if (hv.Length < 2)
                {
                    stringBuilder.Append(0);
                }
                stringBuilder.Append(hv);
            }
            var srcStr = stringBuilder.ToString();
            var chars = srcStr.ToCharArray();
            var bytes = new byte[srcStr.Length / 2];
            int temp;
            for (var i = 0; i < bytes.Length; i++)
            {
                temp = hexstring.IndexOf(chars[2 * i]) << 4;
                temp += hexstring.IndexOf(chars[2 * i + 1]);
                bytes[i] = (byte)(temp & 0xff);
            }

            return Encoding.UTF8.GetString(bytes);
        }

        #region CBC模式

        /// <summary>
        /// DES3 CBC模式加密
        /// </summary>
        /// <param name="key">密钥</param>
        /// <param name="iv">IV</param>
        /// <param name="data">明文的byte数组</param>
        /// <returns>密文的byte数组</returns>
        private static byte[] Des3EncodeCBC(byte[] key, byte[] iv, byte[] data)
        {
            try
            {

                var mStream = new MemoryStream();
                var tdsp = new TripleDESCryptoServiceProvider
                {
                    Mode = CipherMode.CBC,             //默认值
                    Padding = PaddingMode.PKCS7       //默认值
                };
                var cStream = new CryptoStream(mStream, tdsp.CreateEncryptor(key, iv), CryptoStreamMode.Write);
                cStream.Write(data, 0, data.Length);
                cStream.FlushFinalBlock();
                var ret = mStream.ToArray();
                cStream.Close();
                mStream.Close();
                return ret;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                return null;
            }
        }

        /// <summary>
        /// DES3 CBC模式解密
        /// </summary>
        /// <param name="key">密钥</param>
        /// <param name="iv">IV</param>
        /// <param name="data">密文的byte数组</param>
        /// <returns>明文的byte数组</returns>
        private static byte[] Des3DecodeCBC(byte[] key, byte[] iv, byte[] data)
        {
            try
            {
                var msDecrypt = new MemoryStream(data);
                var tdsp = new TripleDESCryptoServiceProvider
                {
                    Mode = CipherMode.CBC,
                    Padding = PaddingMode.PKCS7
                };
                var csDecrypt = new CryptoStream(msDecrypt, tdsp.CreateDecryptor(key, iv), CryptoStreamMode.Read);
                var fromEncrypt = new byte[data.Length];
                csDecrypt.Read(fromEncrypt, 0, fromEncrypt.Length);
                return fromEncrypt;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                return null;
            }
        }

        #endregion

        #region ECB模式

        /// <summary>
        /// DES3 ECB模式加密
        /// </summary>
        /// <param name="key">密钥</param>
        /// <param name="iv">IV(当模式为ECB时，IV无用)</param>
        /// <param name="str">明文的byte数组</param>
        /// <returns>密文的byte数组</returns>
        private static byte[] Des3EncodeECB(byte[] key, byte[] iv, byte[] data)
        {
            try
            {
                var mStream = new MemoryStream();
                var tdsp = new TripleDESCryptoServiceProvider
                {
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.Zeros
                };
                var cStream = new CryptoStream(mStream, tdsp.CreateEncryptor(key, iv), CryptoStreamMode.Write);
                cStream.Write(data, 0, data.Length);
                cStream.FlushFinalBlock();
                var ret = mStream.ToArray();
                cStream.Close();
                mStream.Close();
                return ret;
            }
            catch (CryptographicException e)
            {
                throw new CryptographicException("A Cryptographic error occurred: {0}", e.Message);
            }
        }

        /// <summary>
        /// DES3 ECB模式解密
        /// </summary>
        /// <param name="key">密钥</param>
        /// <param name="iv">IV(当模式为ECB时，IV无用)</param>
        /// <param name="str">密文的byte数组</param>
        /// <returns>明文的byte数组</returns>
        private static byte[] Des3DecodeECB(byte[] key, byte[] iv, byte[] data)
        {
            try
            {
                var msDecrypt = new MemoryStream(data);
                var tdsp = new TripleDESCryptoServiceProvider
                {
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.Zeros
                };
                var csDecrypt = new CryptoStream(msDecrypt, tdsp.CreateDecryptor(key, iv), CryptoStreamMode.Read);
                var fromEncrypt = new byte[data.Length];
                csDecrypt.Read(fromEncrypt, 0, fromEncrypt.Length);
                return fromEncrypt;
            }
            catch (CryptographicException e)
            {
                throw new CryptographicException("A Cryptographic error occurred: {0}", e.Message);
            }
        }

        #endregion

        //将数组转换成16进制字符串
        public static string ByteToHexStr(byte[] bytes)
        {
            var returnStr = "";
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
