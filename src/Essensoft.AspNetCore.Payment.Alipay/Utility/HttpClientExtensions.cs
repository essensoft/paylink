using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.Alipay.Utility
{
    /// <summary>
    /// HTTP客户端扩展。
    /// </summary>
    public static class HttpClientExtensions
    {
        /// <summary>
        /// 执行HTTP POST请求。
        /// </summary>
        /// <param name="client"></param>
        /// <param name="url">请求地址</param>
        /// <param name="dictionary">请求参数</param>
        /// <returns>HTTP响应</returns>
        public static async Task<string> DoPostAsync(this HttpClient client, string url, IDictionary<string, string> dictionary)
        {
            using (var requestContent = new StringContent(AlipayUtility.BuildQuery(dictionary), Encoding.UTF8, "application/x-www-form-urlencoded"))
            using (var response = await client.PostAsync(url, requestContent))
            using (var responseContent = response.Content)
            {
                return await responseContent.ReadAsStringAsync();
            }
        }

        /// <summary>
        /// 执行HTTP POST请求。
        /// </summary>
        /// <param name="client"></param>
        /// <param name="url">请求地址</param>
        /// <param name="content">请求内容</param>
        /// <returns>HTTP响应</returns>
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
        /// <param name="client"></param>
        /// <param name="url">请求地址</param>
        /// <param name="dictionary">请求参数</param>
        /// <returns>HTTP响应</returns>
        public static async Task<string> DoGetAsync(this HttpClient client, string url, IDictionary<string, string> dictionary)
        {
            if (url.Contains("?"))
            {
                url = url + "&" + AlipayUtility.BuildQuery(dictionary);
            }
            else
            {
                url = url + "?" + AlipayUtility.BuildQuery(dictionary);
            }

            using (var response = await client.GetAsync(url))
            using (var responseContent = response.Content)
            {
                return await responseContent.ReadAsStringAsync();
            }
        }

        /// <summary>
        /// 执行带文件上传的HTTP POST请求。
        /// </summary>
        /// <param name="client"></param>
        /// <param name="url">请求地址</param>
        /// <param name="textParams">请求文本参数</param>
        /// <param name="fileParams">请求文件参数</param>
        /// <returns>HTTP响应</returns>
        public static async Task<string> DoPostAsync(this HttpClient client, string url, IDictionary<string, string> textParams, IDictionary<string, FileItem> fileParams)
        {
            // 如果没有文件参数，则走普通POST请求
            if (fileParams == null || fileParams.Count == 0)
            {
                return await DoPostAsync(client, url, textParams);
            }

            // 随机分隔线
            var boundary = DateTime.Now.Ticks.ToString("X");
            using (var requestContent = new MultipartFormDataContent(boundary))
            {
                // 组装文本请求参数
                foreach (var iter in textParams)
                {
                    var streamContent = new StringContent(iter.Value, Encoding.UTF8, "text/plain");
                    requestContent.Add(streamContent, iter.Key);
                }

                // 组装文件请求参数
                foreach (var iter in fileParams)
                {
                    var fileItem = iter.Value;
                    var byteArrayContent = new ByteArrayContent(fileItem.GetContent());
                    byteArrayContent.Headers.ContentType = new MediaTypeHeaderValue(fileItem.GetMimeType());
                    requestContent.Add(byteArrayContent, iter.Key, fileItem.GetFileName());
                }

                using (var response = await client.PostAsync(url, requestContent))
                using (var responseContent = response.Content)
                {
                    return await responseContent.ReadAsStringAsync();
                }
            }
        }
    }
}
