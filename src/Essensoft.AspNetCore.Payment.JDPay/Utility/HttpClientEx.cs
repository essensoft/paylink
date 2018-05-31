using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.JDPay.Utility
{
    public sealed class HttpClientEx : HttpClient
    {
        public HttpClientEx() : base()
        {
            Timeout = new TimeSpan(0, 0, 0, 10);
            DefaultRequestHeaders.Connection.Add("keep-alive");
        }

        /// <summary>
        /// 执行HTTP POST请求。
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="content">请求内容</param>
        /// <returns>HTTP响应</returns>
        public async Task<string> DoPostAsync(string url, string content, string mediaType = "application/xml")
        {
            using (var requestContent = new StringContent(content, Encoding.UTF8, mediaType))
            using (var response = await PostAsync(url, requestContent))
            using (var resContent = response.Content)
            {
                return await resContent.ReadAsStringAsync();
            }
        }

        /// <summary>
        /// 组装普通文本请求参数。
        /// </summary>
        /// <param name="parameters">Key-Value形式请求参数字典</param>
        /// <returns>URL编码后的请求数据</returns>
        public static string BuildQuery(IDictionary<string, string> parameters)
        {
            var content = new StringBuilder();
            foreach (var iter in parameters)
            {
                if (!string.IsNullOrEmpty(iter.Value))
                {
                    content.Append(iter.Key + "=" + WebUtility.UrlEncode(iter.Value) + "&");
                }
            }
            return content.ToString().Substring(0, content.Length - 1);
        }
    }
}
