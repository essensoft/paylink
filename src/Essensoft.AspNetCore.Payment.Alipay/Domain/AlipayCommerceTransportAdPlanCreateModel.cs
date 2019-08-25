using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdPlanCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAdPlanCreateModel : AlipayObject
    {
        /// <summary>
        /// 复杂类型，参见AdPlan定义
        /// </summary>
        [JsonProperty("ad_plan")]
        public AdPlan AdPlan { get; set; }
    }
}
