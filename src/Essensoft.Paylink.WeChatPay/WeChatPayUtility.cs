using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Essensoft.Paylink.WeChatPay
{
    public static class WeChatPayUtility
    {
        /// <summary>
        /// 组装XML格式请求参数。
        /// </summary>
        /// <param name="dictionary">Key-Value形式请求参数字典</param>
        /// <returns>XML格式的请求数据</returns>
        public static string BuildContent(IDictionary<string, string> dictionary)
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                throw new ArgumentNullException(nameof(dictionary));
            }

            var sb = new StringBuilder("<xml>");
            foreach (var iter in dictionary)
            {
                if (!string.IsNullOrEmpty(iter.Value))
                {
                    sb.Append("<" + iter.Key + ">" + "<![CDATA[" + iter.Value + "]]></" + iter.Key + ">");
                }
            }

            return sb.Append("</xml>").ToString();
        }

        /// <summary>
        /// 组装普通文本请求参数。
        /// </summary>
        /// <param name="dictionary">Key-Value形式请求参数字典</param>
        /// <returns>URL编码后的请求数据</returns>
        public static string BuildQuery(IDictionary<string, string> dictionary)
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                throw new ArgumentNullException(nameof(dictionary));
            }

            var sb = new StringBuilder();
            foreach (var iter in dictionary)
            {
                if (!string.IsNullOrEmpty(iter.Value))
                {
                    sb.Append(iter.Key + "=" + WebUtility.UrlEncode(iter.Value) + "&");
                }
            }

            return sb.ToString()[0..^1];
        }

        public static string GetTimeStamp()
        {
            return DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
        }

        public static string GenerateNonceStr()
        {
            return Guid.NewGuid().ToString("N");
        }

        public static string RemovePreFix(this string str, params string[] preFixes)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            if (preFixes == null || preFixes.Length <= 0)
            {
                return str;
            }

            foreach (var preFix in preFixes)
            {
                if (str.StartsWith(preFix))
                {
                    return str[preFix.Length..];
                }
            }

            return str;
        }

        public static string BuildSignatureSourceData(string timestamp, string nonce, string body)
        {
            return $"{timestamp}\n{nonce}\n{body}\n";
        }
    }
}

