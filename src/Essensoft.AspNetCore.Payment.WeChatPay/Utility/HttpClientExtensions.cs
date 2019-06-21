using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Utility
{
    public static class HttpClientExtensions
    {
        /// <summary>
        /// 执行HTTP POST请求。
        /// </summary>
        /// <param name="client">HttpClient</param>
        /// <param name="url">请求地址</param>
        /// <param name="textParams">请求参数</param>
        /// <returns>HTTP响应内容</returns>
        public static async Task<string> PostAsync(this HttpClient client, string url, IDictionary<string, string> textParams)
        {
            using (var reqContent = new StringContent(WeChatPayUtility.BuildContent(textParams), Encoding.UTF8, "application/xml"))
            using (var resp = await client.PostAsync(url, reqContent))
            using (var respContent = resp.Content)
            {
                return await respContent.ReadAsStringAsync();
            }
        }
    }
}
