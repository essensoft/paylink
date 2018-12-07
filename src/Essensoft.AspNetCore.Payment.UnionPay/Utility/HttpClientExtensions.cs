using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.UnionPay.Utility
{
    /// <summary>
    /// HTTP客户端扩展。
    /// </summary>
    public static class HttpClientExtensions
    {
        /// <summary>
        /// 执行HTTP POST请求。
        /// </summary>
        /// <param name="client">客户端</param>
        /// <param name="url">请求地址</param>
        /// <param name="content">内容</param>
        /// <returns>响应内容</returns>
        public static async Task<string> DoPostAsync(this HttpClient client, string url, string content)
        {
            using (var requestContent = new StringContent(content, Encoding.UTF8, "application/x-www-form-urlencoded"))
            using (var response = await client.PostAsync(url, requestContent))
            using (var responseContent = response.Content)
            {
                return await responseContent.ReadAsStringAsync();
            }
        }

        /// <summary>
        /// 执行HTTP GET请求。
        /// </summary>
        /// <param name="client">客户端</param>
        /// <param name="url">请求地址</param>
        /// <param name="dictionary">请求参数</param>
        /// <returns>响应内容</returns>
        public static async Task<string> DoGetAsync(this HttpClient client, string url, IDictionary<string, string> dictionary)
        {
            if (url.Contains("?"))
            {
                url = url + "&" + UnionPayUtility.BuildQuery(dictionary);
            }
            else
            {
                url = url + "?" + UnionPayUtility.BuildQuery(dictionary);
            }

            using (var response = await client.GetAsync(url))
            using (var responseContent = response.Content)
            {
                return await responseContent.ReadAsStringAsync();
            }
        }
    }
}
