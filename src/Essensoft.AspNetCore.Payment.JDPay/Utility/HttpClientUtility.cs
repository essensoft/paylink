using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.JDPay.Utility
{
    public static class HttpClientUtility
    {
        /// <summary>
        /// 执行HTTP POST请求。
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="content">请求内容</param>
        /// <returns>HTTP响应</returns>
        public static async Task<string> DoPostAsync(HttpClient client, string url, string content, string mediaType = "application/xml")
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
