using System;
using System.Collections.Generic;
using System.Text;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Utility
{
    /// <summary>
    /// WeChatPay 工具类。
    /// </summary>
    public static class WeChatPayUtility
    {
        /// <summary>
        /// 组装普通文本请求参数。
        /// </summary>
        /// <param name="dictionary">Key-Value形式请求参数字典</param>
        /// <returns>URL编码后的请求数据</returns>
        public static string BuildContent(IDictionary<string, string> dictionary)
        {
            var content = new StringBuilder("<xml>");
            foreach (var iter in dictionary)
            {
                if (!string.IsNullOrEmpty(iter.Value))
                {
                    content.Append("<" + iter.Key + ">" + "<![CDATA[" + iter.Value + "]]></" + iter.Key + ">");
                }
            }
            return content.Append("</xml>").ToString();
        }

        public static string GetTimeStamp()
        {
            return DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
        }
    }
}
