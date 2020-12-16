using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BenefitDateInfo Data Structure.
    /// </summary>
    public class BenefitDateInfo : AlipayObject
    {
        /// <summary>
        /// 激活时间
        /// </summary>
        [JsonPropertyName("benefit_active_time")]
        public string BenefitActiveTime { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonPropertyName("benefit_expired_time")]
        public string BenefitExpiredTime { get; set; }

        /// <summary>
        /// 发放时间
        /// </summary>
        [JsonPropertyName("benefit_issue_time")]
        public string BenefitIssueTime { get; set; }
    }
}
