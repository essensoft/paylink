using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DocInfo Data Structure.
    /// </summary>
    public class DocInfo : AlipayObject
    {
        /// <summary>
        /// 合同文件名
        /// </summary>
        [JsonPropertyName("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 合同下载地址
        /// </summary>
        [JsonPropertyName("file_url")]
        public string FileUrl { get; set; }
    }
}
