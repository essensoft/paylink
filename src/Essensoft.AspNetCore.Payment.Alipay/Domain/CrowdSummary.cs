using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CrowdSummary Data Structure.
    /// </summary>
    public class CrowdSummary : AlipayObject
    {
        /// <summary>
        /// 人群数量
        /// </summary>
        [JsonPropertyName("crowd_count")]
        public long CrowdCount { get; set; }

        /// <summary>
        /// 生活号人群id
        /// </summary>
        [JsonPropertyName("crowd_id")]
        public string CrowdId { get; set; }

        /// <summary>
        /// 人群名称
        /// </summary>
        [JsonPropertyName("crowd_name")]
        public string CrowdName { get; set; }

        /// <summary>
        /// 人群状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
