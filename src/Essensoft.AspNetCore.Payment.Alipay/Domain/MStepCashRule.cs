using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MStepCashRule Data Structure.
    /// </summary>
    public class MStepCashRule : AlipayObject
    {
        /// <summary>
        /// 优惠金额(单位:分)
        /// </summary>
        [JsonPropertyName("reduction_amount")]
        public long ReductionAmount { get; set; }

        /// <summary>
        /// 起步金额(单位:分)
        /// </summary>
        [JsonPropertyName("threshold_amount")]
        public long ThresholdAmount { get; set; }
    }
}
