using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
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

            var boundary = DateTime.Now.Ticks.ToString("X"); // 随机分隔线

            var reqStream = new MemoryStream();
            var itemBoundaryBytes = Encoding.UTF8.GetBytes("\r\n--" + boundary + "\r\n");
            var endBoundaryBytes = Encoding.UTF8.GetBytes("\r\n--" + boundary + "--\r\n");

            // 组装文本请求参数
            var textTemplate = "Content-Disposition:form-data;name=\"{0}\"\r\nContent-Type:text/plain\r\n\r\n{1}";
            foreach (var iter in textParams)
            {
                var textEntry = string.Format(textTemplate, iter.Key, iter.Value);
                var itemBytes = Encoding.UTF8.GetBytes(textEntry);
                reqStream.Write(itemBoundaryBytes, 0, itemBoundaryBytes.Length);
                reqStream.Write(itemBytes, 0, itemBytes.Length);
            }

            // 组装文件请求参数
            var fileTemplate = "Content-Disposition:form-data;name=\"{0}\";filename=\"{1}\"\r\nContent-Type:{2}\r\n\r\n";
            foreach (var iter in fileParams)
            {
                var key = iter.Key;
                var fileItem = iter.Value;
                var fileEntry = string.Format(fileTemplate, key, fileItem.GetFileName(), fileItem.GetMimeType());
                var itemBytes = Encoding.UTF8.GetBytes(fileEntry);
                reqStream.Write(itemBoundaryBytes, 0, itemBoundaryBytes.Length);
                reqStream.Write(itemBytes, 0, itemBytes.Length);

                var fileBytes = fileItem.GetContent();
                reqStream.Write(fileBytes, 0, fileBytes.Length);
            }

            reqStream.Write(endBoundaryBytes, 0, endBoundaryBytes.Length);

            using (var requestContent = new StringContent(reqStream.ToString(), Encoding.UTF8, "multipart/form-data;boundary=" + boundary))
            using (var response = await client.PostAsync(url, requestContent))
            using (var responseContent = response.Content)
            {
                return await responseContent.ReadAsStringAsync();
            }
        }
    }
}
