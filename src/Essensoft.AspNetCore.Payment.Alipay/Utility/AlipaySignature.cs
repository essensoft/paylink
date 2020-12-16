using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Essensoft.AspNetCore.Payment.Security;

namespace Essensoft.AspNetCore.Payment.Alipay.Utility
{
    public static class AlipaySignature
    {
        public static readonly byte[] AES_IV = InitIv(16);

        public static string GetSignContent(IDictionary<string, string> dictionary)
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                return string.Empty;
            }

            var sortPara = new SortedDictionary<string, string>(dictionary);
            var sb = new StringBuilder();
            foreach (var iter in sortPara)
            {
                if (!string.IsNullOrEmpty(iter.Value))
                {
                    sb.Append(iter.Key).Append('=').Append(iter.Value).Append('&');
                }
            }

            return sb.Remove(sb.Length - 1, 1).ToString();
        }

        public static string RSASignContent(string data, string privateKey, string signType)
        {
            return signType switch
            {
                "RSA1" => SHA1WithRSA.Sign(data, privateKey),
                "RSA2" => SHA256WithRSA.Sign(data, privateKey),
                _ => SHA1WithRSA.Sign(data, privateKey),
            };
        }

        public static bool RSACheckContent(string data, string sign, string publicKey, string signType)
        {
            return signType switch
            {
                "RSA1" => SHA1WithRSA.Verify(data, sign, publicKey),
                "RSA2" => SHA256WithRSA.Verify(data, sign, publicKey),
                _ => SHA1WithRSA.Verify(data, sign, publicKey),
            };
        }

        public static string AESEncrypt(string data, string encyptKey)
        {
            return AES.Encrypt(data, encyptKey, AES_IV, CipherMode.CBC, PaddingMode.PKCS7);
        }

        public static string AESDencrypt(string data, string encyptKey)
        {
            return AES.Decrypt(data, encyptKey, AES_IV, CipherMode.CBC, PaddingMode.PKCS7);
        }

        private static byte[] InitIv(int blockSize)
        {
            var iv = new byte[blockSize];
            for (var i = 0; i < blockSize; i++)
            {
                iv[i] = 0x0;
            }

            return iv;
        }

        public static SignSourceData ExtractSignContent(string str, int begin)
        {
            if (str == null)
            {
                return null;
            }

            var beginIndex = ExtractBeginPosition(str, begin);
            if (beginIndex >= str.Length)
            {
                return null;
            }

            var endIndex = ExtractEndPosition(str, beginIndex);
            return new SignSourceData()
            {
                SourceData = str[beginIndex..endIndex],
                BeginIndex = beginIndex,
                EndIndex = endIndex
            };
        }

        private static int ExtractBeginPosition(string responseString, int begin)
        {
            var beginPosition = begin;
            //找到第一个左大括号（对应响应的是JSON对象的情况：普通调用OpenAPI响应明文）
            //或者双引号（对应响应的是JSON字符串的情况：加密调用OpenAPI响应Base64串），作为待验签内容的起点
            while (beginPosition < responseString.Length && responseString[beginPosition] != '{' && responseString[beginPosition] != '"')
            {
                ++beginPosition;
            }
            return beginPosition;
        }

        private static int ExtractEndPosition(string responseString, int beginPosition)
        {
            //提取明文验签内容终点
            if (responseString[beginPosition] == '{')
            {
                return ExtractJsonObjectEndPosition(responseString, beginPosition);
            }
            //提取密文验签内容终点
            else
            {
                return ExtractJsonBase64ValueEndPosition(responseString, beginPosition);
            }
        }

        private static int ExtractJsonBase64ValueEndPosition(string responseString, int beginPosition)
        {
            for (var index = beginPosition; index < responseString.Length; ++index)
            {
                //找到第2个双引号作为终点，由于中间全部是Base64编码的密文，所以不会有干扰的特殊字符
                if (responseString[index] == '"' && index != beginPosition)
                {
                    return index + 1;
                }
            }
            //如果没有找到第2个双引号，说明验签内容片段提取失败，直接尝试选取剩余整个响应字符串进行验签
            return responseString.Length;
        }

        private static int ExtractJsonObjectEndPosition(string responseString, int beginPosition)
        {
            //记录当前尚未发现配对闭合的大括号
            var braces = new LinkedList<string>();
            //记录当前字符是否在双引号中
            var inQuotes = false;
            //记录当前字符前面连续的转义字符个数
            var consecutiveEscapeCount = 0;
            //从待验签字符的起点开始遍历后续字符串，找出待验签字符串的终止点，终点即是与起点{配对的}
            for (var index = beginPosition; index < responseString.Length; ++index)
            {
                //提取当前字符
                var currentChar = responseString[index];

                //如果当前字符是"且前面有偶数个转义标记（0也是偶数）
                if (currentChar == '"' && consecutiveEscapeCount % 2 == 0)
                {
                    //是否在引号中的状态取反
                    inQuotes = !inQuotes;
                }
                //如果当前字符是{且不在引号中
                else if (currentChar == '{' && !inQuotes)
                {
                    //将该{加入未闭合括号中
                    braces.AddLast("{");
                }
                //如果当前字符是}且不在引号中
                else if (currentChar == '}' && !inQuotes)
                {
                    //弹出一个未闭合括号
                    braces.RemoveLast();
                    //如果弹出后，未闭合括号为空，说明已经找到终点
                    if (braces.Count == 0)
                    {
                        return index + 1;
                    }
                }

                //如果当前字符是转义字符
                if (currentChar == '\\')
                {
                    //连续转义字符个数+1
                    ++consecutiveEscapeCount;
                }
                else
                {
                    //连续转义字符个数置0
                    consecutiveEscapeCount = 0;
                }
            }

            //如果没有找到配对的闭合括号，说明验签内容片段提取失败，直接尝试选取剩余整个响应字符串进行验签
            return responseString.Length;
        }
    }
}
