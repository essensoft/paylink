using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MStepCashRule Data Structure.
    /// </summary>
    [Serializable]
    public class MStepCashRule : AlipayObject
    {
        /// <summary>
        /// 优惠金额(单位:分)
        /// </summary>
        [JsonProperty("reduction_amount")]
        public long ReductionAmount { get; set; }

        /// <summary>
        /// 起步金额(单位:分)
        /// </summary>
        [JsonProperty("threshold_amount")]
        public long ThresholdAmount { get; set; }
    }
}
