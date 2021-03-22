using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// PromoInfo Data Structure.
    /// </summary>
    public class PromoInfo : AlipayObject
    {
        /// <summary>
        /// 最高优惠金额，仅针对折扣券
        /// </summary>
        [JsonPropertyName("ceiling_amount")]
        public string CeilingAmount { get; set; }

        /// <summary>
        /// 券金额，仅针对代金券
        /// </summary>
        [JsonPropertyName("reduction_amount")]
        public string ReductionAmount { get; set; }

        /// <summary>
        /// 优惠额度，如3折券，返回0.7，仅针对折扣券
        /// </summary>
        [JsonPropertyName("reduction_ratio")]
        public string ReductionRatio { get; set; }

        /// <summary>
        /// 减至金额，仅针对减至券
        /// </summary>
        [JsonPropertyName("specified_amount")]
        public string SpecifiedAmount { get; set; }
    }
}
