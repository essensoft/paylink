using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Essensoft.AspNetCore.Payment.Alipay.Utility
{
    /// <summary>
    /// Alipay 工具类。
    /// </summary>
    public static class AlipayUtility
    {
        /// <summary>
        /// 组装普通文本请求参数
        /// </summary>
        /// <param name="dictionary">请求参数字典</param>
        /// <returns>URL编码后的请求数据</returns>
        public static string BuildQuery(IDictionary<string, string> dictionary)
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                throw new ArgumentNullException(nameof(dictionary));
            }

            var content = new StringBuilder();
            foreach (var iter in dictionary)
            {
                if (!string.IsNullOrEmpty(iter.Value))
                {
                    content.Append(iter.Key + "=" + WebUtility.UrlEncode(iter.Value) + "&");
                }
            }
            return content.ToString().Substring(0, content.Length - 1);
        }

        /// <summary>
        /// 清除字典中值为空的项。
        /// </summary>
        /// <param name="dictionary">待清除的字典</param>
        /// <returns>清除后的字典</returns>
        public static IDictionary<string, T> CleanupDictionary<T>(IDictionary<string, T> dictionary)
        {
            var dic = new Dictionary<string, T>();
            foreach (var kv in dictionary)
            {
                if (kv.Value != null)
                {
                    dic.Add(kv.Key, kv.Value);
                }
            }
            return dic;
        }

        /// <summary>
        /// 获取文件的真实后缀名。目前只支持JPG, GIF, PNG, BMP四种图片文件。
        /// </summary>
        /// <param name="fileData">文件字节流</param>
        /// <returns>JPG, GIF, PNG or null</returns>
        public static string GetFileSuffix(byte[] fileData)
        {
            if (fileData == null || fileData.Length < 10)
            {
                return null;
            }

            if (fileData[0] == 'G' && fileData[1] == 'I' && fileData[2] == 'F')
            {
                return "GIF";
            }

            if (fileData[1] == 'P' && fileData[2] == 'N' && fileData[3] == 'G')
            {
                return "PNG";
            }

            if (fileData[6] == 'J' && fileData[7] == 'F' && fileData[8] == 'I' && fileData[9] == 'F')
            {
                return "JPG";
            }

            if (fileData[0] == 'B' && fileData[1] == 'M')
            {
                return "BMP";
            }

            return null;
        }

        /// <summary>
        /// 获取文件的真实媒体类型。目前只支持JPG, GIF, PNG, BMP四种图片文件。
        /// </summary>
        /// <param name="fileData">文件字节流</param>
        /// <returns>媒体类型</returns>
        public static string GetMimeType(byte[] fileData)
        {
            var suffix = GetFileSuffix(fileData);
            var mimeType = suffix switch
            {
                "JPG" => "image/jpeg",
                "GIF" => "image/gif",
                "PNG" => "image/png",
                "BMP" => "image/bmp",
                _ => "application/octet-stream",
            };
            return mimeType;
        }

        /// <summary>
        /// 根据文件后缀名获取文件的媒体类型。
        /// </summary>
        /// <param name="fileName">带后缀的文件名或文件全名</param>
        /// <returns>媒体类型</returns>
        public static string GetMimeType(string fileName)
        {
            string mimeType;
            fileName = fileName.ToLowerInvariant();

            if (fileName.EndsWith(".bmp", StringComparison.CurrentCulture))
            {
                mimeType = "image/bmp";
            }
            else if (fileName.EndsWith(".gif", StringComparison.CurrentCulture))
            {
                mimeType = "image/gif";
            }
            else if (fileName.EndsWith(".jpg", StringComparison.CurrentCulture) || fileName.EndsWith(".jpeg", StringComparison.CurrentCulture))
            {
                mimeType = "image/jpeg";
            }
            else if (fileName.EndsWith(".png", StringComparison.CurrentCulture))
            {
                mimeType = "image/png";
            }
            else
            {
                mimeType = "application/octet-stream";
            }

            return mimeType;
        }

        /// <summary>
        /// 根据API名称获取响应根节点名称。
        /// </summary>
        /// <param name="api">API名称</param>
        public static string GetRootElement(string api)
        {
            var pos = api.IndexOf(".");
            if (pos != -1 && api.Length > pos)
            {
                api = api.Substring(pos + 1).Replace('.', '_');
            }

            return api + AlipayConstants.RESPONSE_SUFFIX;
        }
    }
}
