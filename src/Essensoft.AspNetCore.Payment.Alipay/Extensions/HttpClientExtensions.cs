using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.Alipay.Utility;

namespace Essensoft.AspNetCore.Payment.Alipay.Extensions
{
    public static class HttpClientExtensions
    {
        /// <summary>
        /// 执行HTTP POST请求。
        /// </summary>
        /// <param name="client">HttpClient</param>
        /// <param name="url">请求地址</param>
        /// <param name="textParams">请求参数</param>
        /// <returns>响应内容</returns>
        public static async Task<string> PostAsync(this HttpClient client, string url, IDictionary<string, string> textParams)
        {
            using (var reqContent = new StringContent(AlipayUtility.BuildQuery(textParams), Encoding.UTF8, "application/x-www-form-urlencoded"))
            using (var resp = await client.PostAsync(url, reqContent))
            using (var respContent = resp.Content)
            {
                return await respContent.ReadAsStringAsync();
            }
        }

        /// <summary>
        /// 执行带文件上传的HTTP POST请求。
        /// </summary>
        /// <param name="client">HttpClient</param>
        /// <param name="url">请求地址</param>
        /// <param name="textParams">请求文本参数</param>
        /// <param name="fileParams">请求文件参数</param>
        /// <returns>响应内容</returns>
        public static async Task<string> PostAsync(this HttpClient client, string url, IDictionary<string, string> textParams, IDictionary<string, FileItem> fileParams)
        {
            // 如果没有文件参数，则走普通POST请求
            if (fileParams == null || fileParams.Count == 0)
            {
                return await PostAsync(client, url, textParams);
            }

            // 随机分隔线
            var boundary = DateTime.Now.Ticks.ToString("X");
            using (var reqContent = new MultipartFormDataContent(boundary))
            {
                // 组装文本请求参数
                foreach (var iter in textParams)
                {
                    reqContent.Add(new StringContent(iter.Value, Encoding.UTF8, "text/plain"), $@"""{iter.Key}""");
                }

                // 组装文件请求参数
                foreach (var iter in fileParams)
                {
                    var name = iter.Key;
                    var fileItem = iter.Value;
                    var byteArrayContent = new ByteArrayContent(fileItem.GetContent());
                    byteArrayContent.Headers.ContentType = new MediaTypeHeaderValue(fileItem.GetMimeType());
                    reqContent.Add(byteArrayContent, @"""{name}""", @"""{ fileItem.GetFileName()}""");
                }

                using (var resp = await client.PostAsync(url, reqContent))
                using (var respContent = resp.Content)
                {
                    return await respContent.ReadAsStringAsync();
                }
            }
        }
    }
}
