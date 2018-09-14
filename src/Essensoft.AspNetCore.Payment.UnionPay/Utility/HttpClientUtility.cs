using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.UnionPay.Utility
{
    /// <summary>
    /// 网络工具类。
    /// </summary>
    public static class HttpClientUtility
    {
        /// <summary>
        /// 执行HTTP POST请求。
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="content">请求参数</param>
        /// <returns>HTTP响应</returns>
        public static async Task<string> DoPostAsync(HttpClient client, string url, string content)
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
        /// <param name="url">请求地址</param>
        /// <param name="parameters">请求参数</param>
        /// <returns>HTTP响应</returns>
        public static async Task<string> DoGetAsync(HttpClient client, string url, IDictionary<string, string> parameters)
        {
            if (parameters?.Count > 0)
            {
                if (url.Contains("?"))
                {
                    url = url + "&" + UnionPayUtility.BuildQuery(parameters);
                }
                else
                {
                    url = url + "?" + UnionPayUtility.BuildQuery(parameters);
                }
            }

            using (var response = await client.GetAsync(url))
            using (var responseContent = response.Content)
            {
                return await responseContent.ReadAsStringAsync();
            }
        }
    }
}
