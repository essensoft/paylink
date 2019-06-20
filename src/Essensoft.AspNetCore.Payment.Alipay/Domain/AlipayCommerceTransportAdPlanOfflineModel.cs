using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdPlanOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAdPlanOfflineModel : AlipayObject
    {
        /// <summary>
        /// 广告主id + 下线计划操作时，需要校验该plan是否属于该广告主
        /// </summary>
        [JsonProperty("ad_user_id")]
        public long AdUserId { get; set; }

        /// <summary>
        /// 广告计划id + 根据广告计划id下线对应的广告计划
        /// </summary>
        [JsonProperty("plan_id")]
        public long PlanId { get; set; }
    }
}
