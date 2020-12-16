using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PromoInfo Data Structure.
    /// </summary>
    public class PromoInfo : AlipayObject
    {
        /// <summary>
        /// 最高优惠金额
        /// </summary>
        [JsonPropertyName("ceiling_amount")]
        public string CeilingAmount { get; set; }

        /// <summary>
        /// 代金券，券金额
        /// </summary>
        [JsonPropertyName("reduction_amount")]
        public string ReductionAmount { get; set; }

        /// <summary>
        /// 优惠额度，如3折券，reduction_ratio=0.7
        /// </summary>
        [JsonPropertyName("reduction_ratio")]
        public string ReductionRatio { get; set; }

        /// <summary>
        /// 特价券减至金额
        /// </summary>
        [JsonPropertyName("specified_amount")]
        public string SpecifiedAmount { get; set; }
    }
}
