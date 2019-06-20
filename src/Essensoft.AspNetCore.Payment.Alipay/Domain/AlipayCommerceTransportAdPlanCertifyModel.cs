using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdPlanCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAdPlanCertifyModel : AlipayObject
    {
        /// <summary>
        /// 广告系统用户ID
        /// </summary>
        [JsonProperty("ad_user_id")]
        public long AdUserId { get; set; }

        /// <summary>
        /// 广告计划ID
        /// </summary>
        [JsonProperty("plan_id")]
        public long PlanId { get; set; }
    }
}
