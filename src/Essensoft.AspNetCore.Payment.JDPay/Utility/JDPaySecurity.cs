using Essensoft.AspNetCore.Payment.Security;
using Org.BouncyCastle.Crypto;
using System;
using System.Text;

namespace Essensoft.AspNetCore.Payment.JDPay.Utility
{
    public class JDPaySecurity
    {
        private const int MAX_MSG_LENGTH = 16 * 1024;
        private static byte[] iv = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

        public static string GetSignContent(JDPayDictionary para)
        {
            if (para == null || para.Count == 0)
                return string.Empty;

            var sb = new StringBuilder();
            foreach (var iter in para)
            {
                if (!string.IsNullOrEmpty(iter.Value) && iter.Key != "sign")
                    sb.Append(iter.Key).Append("=").Append(iter.Value).Append("&");
            }

            return sb.Remove(sb.Length - 1, 1).ToString();
        }

        public static string RSASign(string sourceSignString, AsymmetricKeyParameter privateKey)
        {
            var sha256SourceSignString = Security.SHA256.Compute(sourceSignString);
            var newsks = RSA_ECB_PKCS1Padding.Encrypt(Encoding.UTF8.GetBytes(sha256SourceSignString), privateKey);
            return Convert.ToBase64String(newsks, Base64FormattingOptions.InsertLineBreaks);
        }

        public static bool RSACheckContent(string content, string sign, AsymmetricKeyParameter publicKey)
        {
            var sha256SourceSignString = Security.SHA256.Compute(content);
            var decryptArr = RSA_ECB_PKCS1Padding.Decrypt(Convert.FromBase64String(sign), publicKey);
            var decrypStr = Encoding.UTF8.GetString(decryptArr);
            return sha256SourceSignString.Equals(decrypStr);
        }

        public static string EncryptECB(string data, byte[] key)
        {
            var resultByte = InitResultByteArray(data);
            var desdata = DES3.Encode(resultByte, key, iv, DESCipherMode.ECB, DESPaddingMode.Zeros);
            return ByteToHexStr(desdata);
        }

        public static string DecryptECB(string data, byte[] key)
        {
            var hexSourceData = Hex2byte(data);
            var unDesResult = DES3.Decode(hexSourceData, key, iv, DESCipherMode.ECB, DESPaddingMode.Zeros);
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

        public static string ByteToHexStr(byte[] bytes)
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
