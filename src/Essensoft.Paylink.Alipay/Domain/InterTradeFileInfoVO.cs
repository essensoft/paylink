using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// InterTradeFileInfoVO Data Structure.
    /// </summary>
    public class InterTradeFileInfoVO : AlipayObject
    {
        /// <summary>
        /// 文件名称
        /// </summary>
        [JsonPropertyName("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 关联交易审批单发起来源
        /// </summary>
        [JsonPropertyName("file_source")]
        public string FileSource { get; set; }

        /// <summary>
        /// 文件存储类型
        /// </summary>
        [JsonPropertyName("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 文件地址
        /// </summary>
        [JsonPropertyName("file_url")]
        public string FileUrl { get; set; }
    }
}
