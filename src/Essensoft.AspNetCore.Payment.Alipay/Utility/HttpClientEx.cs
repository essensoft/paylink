using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.Alipay.Utility
{
    /// <summary>
    /// 网络工具类。
    /// </summary>
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
        /// <param name="parameters">请求参数</param>
        /// <returns>HTTP响应</returns>
        public async Task<string> DoPostAsync(string url, IDictionary<string, string> parameters)
        {
            using (var requestContent = new StringContent(BuildQuery(parameters), Encoding.UTF8, "application/x-www-form-urlencoded"))
            using (var response = await PostAsync(url, requestContent))
            using (var responseContent = response.Content)
            {
                return await responseContent.ReadAsStringAsync();
            }
        }

        /// <summary>
        /// 执行HTTP POST请求。
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="content">请求内容</param>
        /// <returns>HTTP响应</returns>
        public async Task<string> DoPostAsync(string url, string content)
        {
            using (var requestContent = new StringContent(content, Encoding.UTF8, "application/x-www-form-urlencoded"))
            using (var response = await PostAsync(url, requestContent))
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
        public async Task<string> DoGetAsync(string url, IDictionary<string, string> parameters)
        {
            if (parameters?.Count > 0)
            {
                if (url.Contains("?"))
                {
                    url = url + "&" + BuildQuery(parameters);
                }
                else
                {
                    url = url + "?" + BuildQuery(parameters);
                }
            }

            using (var response = await GetAsync(url))
            using (var responseContent = response.Content)
            {
                return await responseContent.ReadAsStringAsync();
            }
        }

        /// <summary>
        /// 执行带文件上传的HTTP POST请求。
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="textParams">请求文本参数</param>
        /// <param name="fileParams">请求文件参数</param>
        /// <returns>HTTP响应</returns>
        public async Task<string> DoPostAsync(string url, IDictionary<string, string> textParams, IDictionary<string, FileItem> fileParams)
        {
            // 如果没有文件参数，则走普通POST请求
            if (fileParams == null || fileParams.Count == 0)
            {
                return await DoPostAsync(url, textParams);
            }

            var boundary = DateTime.Now.Ticks.ToString("X"); // 随机分隔线

            var reqStream = new MemoryStream();
            var itemBoundaryBytes = Encoding.UTF8.GetBytes("\r\n--" + boundary + "\r\n");
            var endBoundaryBytes = Encoding.UTF8.GetBytes("\r\n--" + boundary + "--\r\n");

            // 组装文本请求参数
            var textTemplate = "Content-Disposition:form-data;name=\"{0}\"\r\nContent-Type:text/plain\r\n\r\n{1}";
            foreach (var item in textParams)
            {
                var textEntry = string.Format(textTemplate, item.Key, item.Value);
                var itemBytes = Encoding.UTF8.GetBytes(textEntry);
                reqStream.Write(itemBoundaryBytes, 0, itemBoundaryBytes.Length);
                reqStream.Write(itemBytes, 0, itemBytes.Length);
            }

            // 组装文件请求参数
            var fileTemplate = "Content-Disposition:form-data;name=\"{0}\";filename=\"{1}\"\r\nContent-Type:{2}\r\n\r\n";
            foreach (var item in fileParams)
            {
                var key = item.Key;
                var fileItem = item.Value;
                var fileEntry = string.Format(fileTemplate, key, fileItem.GetFileName(), fileItem.GetMimeType());
                var itemBytes = Encoding.UTF8.GetBytes(fileEntry);
                reqStream.Write(itemBoundaryBytes, 0, itemBoundaryBytes.Length);
                reqStream.Write(itemBytes, 0, itemBytes.Length);

                var fileBytes = fileItem.GetContent();
                reqStream.Write(fileBytes, 0, fileBytes.Length);
            }

            reqStream.Write(endBoundaryBytes, 0, endBoundaryBytes.Length);

            using (var requestContent = new StringContent(reqStream.ToString(), Encoding.UTF8, "multipart/form-data;boundary=" + boundary))
            using (var response = await PostAsync(url, requestContent))
            using (var responseContent = response.Content)
            {
                return await responseContent.ReadAsStringAsync();
            }
        }

        /// <summary>
        /// 组装普通文本请求参数。
        /// </summary>
        /// <param name="parameters">Key-Value形式请求参数字典</param>
        /// <returns>URL编码后的请求数据</returns>
        public static string BuildQuery(IDictionary<string, string> parameters)
        {
            if (parameters == null || parameters.Count == 0)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

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
