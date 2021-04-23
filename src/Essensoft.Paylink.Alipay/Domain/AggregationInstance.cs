using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AggregationInstance Data Structure.
    /// </summary>
    public class AggregationInstance : AlipayObject
    {
        /// <summary>
        /// 模版ID
        /// </summary>
        [JsonPropertyName("aggr_id")]
        public string AggrId { get; set; }

        /// <summary>
        /// 请求的幂等参数
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 实例的生效起始时间
        /// </summary>
        [JsonPropertyName("gmt_active")]
        public string GmtActive { get; set; }

        /// <summary>
        /// 实例过期时间
        /// </summary>
        [JsonPropertyName("gmt_expire")]
        public string GmtExpire { get; set; }

        /// <summary>
        /// 权益实例ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 实例所对应的外部权益，如券
        /// </summary>
        [JsonPropertyName("out_id")]
        public string OutId { get; set; }

        /// <summary>
        /// 请求的用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
