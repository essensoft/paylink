using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// CountInfo Data Structure.
    /// </summary>
    public class CountInfo : AlipayObject
    {
        /// <summary>
        /// 飞猪内容id
        /// </summary>
        [JsonProperty("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 点赞数
        /// </summary>
        [JsonProperty("support_count")]
        public long SupportCount { get; set; }

        /// <summary>
        /// 阅读数
        /// </summary>
        [JsonProperty("total_page_view_count")]
        public long TotalPageViewCount { get; set; }
    }
}
