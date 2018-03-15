using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.JdPay.Utility
{
    public sealed class HttpClientEx : HttpClient
    {
        public HttpClientEx()
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
        public async Task<string> DoPostAsync(string url, string content)
        {
            using (var requestContent = new StringContent(content, Encoding.UTF8, "application/xml"))
            using (var response = await PostAsync(url, requestContent))
            using (var resContent = response.Content)
            {
                return await resContent.ReadAsStringAsync();
            }
        }
    }
}
