using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishBaseActivityInfo Data Structure.
    /// </summary>
    public class KbdishBaseActivityInfo : AlipayObject
    {
        /// <summary>
        /// 活动条款链接
        /// </summary>
        [JsonPropertyName("activity_clause_url")]
        public string ActivityClauseUrl { get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动说明文案
        /// </summary>
        [JsonPropertyName("activity_remark")]
        public string ActivityRemark { get; set; }

        /// <summary>
        /// 活动类型
        /// </summary>
        [JsonPropertyName("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 活动值
        /// </summary>
        [JsonPropertyName("activity_value")]
        public string ActivityValue { get; set; }
    }
}
