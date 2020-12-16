using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BenefitAmountInfo Data Structure.
    /// </summary>
    public class BenefitAmountInfo : AlipayObject
    {
        /// <summary>
        /// 可用面额
        /// </summary>
        [JsonPropertyName("benefit_available_amount")]
        public Amount BenefitAvailableAmount { get; set; }

        /// <summary>
        /// 总面额
        /// </summary>
        [JsonPropertyName("benefit_total_amount")]
        public Amount BenefitTotalAmount { get; set; }
    }
}
