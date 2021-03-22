using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// JointAccountQuotaRespDTO Data Structure.
    /// </summary>
    public class JointAccountQuotaRespDTO : AlipayObject
    {
        /// <summary>
        /// 额度维度
        /// </summary>
        [JsonPropertyName("quota_dimension")]
        public string QuotaDimension { get; set; }

        /// <summary>
        /// 剩余额度
        /// </summary>
        [JsonPropertyName("quota_remain")]
        public string QuotaRemain { get; set; }

        /// <summary>
        /// 协议额度
        /// </summary>
        [JsonPropertyName("quota_total")]
        public string QuotaTotal { get; set; }

        /// <summary>
        /// 已用额度
        /// </summary>
        [JsonPropertyName("quota_used")]
        public string QuotaUsed { get; set; }
    }
}
