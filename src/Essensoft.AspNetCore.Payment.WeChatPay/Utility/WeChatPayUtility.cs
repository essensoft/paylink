using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Utility
{
    public static class WeChatPayUtility
    {
        public static readonly string DefaultClientName = "Payment.WechatPay.Client";
        public static readonly string CertificateClientName = "Payment.WechatPay.CertificateClient";

        /// <summary>
        /// 组装普通文本请求参数。
        /// </summary>
        /// <param name="parameters">Key-Value形式请求参数字典</param>
        /// <returns>URL编码后的请求数据</returns>
        public static string BuildContent(IDictionary<string, string> parameters)
        {
            var content = new StringBuilder("<xml>");
            foreach (var iter in parameters)
            {
                if (!string.IsNullOrEmpty(iter.Value))
                {
                    content.Append("<" + iter.Key + ">" + "<![CDATA[" + iter.Value + "]]></" + iter.Key + ">");
                }
            }
            return content.Append("</xml>").ToString();
        }

        internal static bool HasTextJsonContentType(this HttpRequest request)
        {
            // Content-Type: text/json;charset=UTF-8
            MediaTypeHeaderValue.TryParse(request.ContentType, out var contentType);
            return contentType != null && contentType.MediaType.Equals("text/json", StringComparison.OrdinalIgnoreCase);
        }

        public static string GetTimeStamp()
        {
            var ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }
    }
}
