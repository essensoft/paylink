using System.Collections.Generic;
using System.Text;

namespace Essensoft.AspNetCore.Payment.QPay.Utility
{
    public static class QPayUtility
    {
        public static readonly string DefaultClientName = "Payment.QPay.Client";
        public static readonly string CertificateClientName = "Payment.QPay.CertificateClient";

        /// <summary>
        /// 组装普通文本请求参数。
        /// </summary>
        /// <param name="parameters">Key-Value形式请求参数字典</param>
        /// <returns>URL编码后的请求数据</returns>
        public static string BuildContent(IDictionary<string, string> parameters)
        {
            var content = new StringBuilder("<xml>");
            foreach (var iter in parameters)
            {
                if (!string.IsNullOrEmpty(iter.Value))
                {
                    content.Append("<" + iter.Key + ">" + "<![CDATA[" + iter.Value + "]]></" + iter.Key + ">");
                }
            }
            return content.Append("</xml>").ToString();
        }
    }
}
