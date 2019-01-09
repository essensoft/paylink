using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.JDPay.Utility
{
    /// <summary>
    /// HTTP客户端扩展。
    /// </summary>
    public static class HttpClientExtensions
    {
        /// <summary>
        /// 执行HTTP POST请求。
        /// </summary>
        /// <param name="client">HttpClient</param>
        /// <param name="url">请求地址</param>
        /// <param name="content">请求内容</param>
        /// <param name="mediaType">媒体类型</param>
        /// <returns>HTTP响应内容</returns>
        public static async Task<string> DoPostAsync(this HttpClient client, string url, string content, string mediaType = "application/xml")
        {
            using (var requestContent = new StringContent(content, Encoding.UTF8, mediaType))
            using (var response = await client.PostAsync(url, requestContent))
            using (var resContent = response.Content)
            {
                return await resContent.ReadAsStringAsync();
            }
        }
    }
}
