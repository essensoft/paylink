using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BenefitDisplayInfo Data Structure.
    /// </summary>
    public class BenefitDisplayInfo : AlipayObject
    {
        /// <summary>
        /// 权益描述
        /// </summary>
        [JsonPropertyName("benefit_description")]
        public string BenefitDescription { get; set; }

        /// <summary>
        /// 权益icon
        /// </summary>
        [JsonPropertyName("benefit_icon_url")]
        public string BenefitIconUrl { get; set; }

        /// <summary>
        /// 权益名称
        /// </summary>
        [JsonPropertyName("benefit_name")]
        public string BenefitName { get; set; }

        /// <summary>
        /// 透传信息
        /// </summary>
        [JsonPropertyName("pass_through_info")]
        public string PassThroughInfo { get; set; }
    }
}
