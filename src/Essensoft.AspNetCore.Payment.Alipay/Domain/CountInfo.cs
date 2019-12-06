using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CountInfo Data Structure.
    /// </summary>
    public class CountInfo : AlipayObject
    {
        /// <summary>
        /// 飞猪内容id
        /// </summary>
        [JsonPropertyName("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 点赞数
        /// </summary>
        [JsonPropertyName("support_count")]
        public long SupportCount { get; set; }

        /// <summary>
        /// 阅读数
        /// </summary>
        [JsonPropertyName("total_page_view_count")]
        public long TotalPageViewCount { get; set; }
    }
}
