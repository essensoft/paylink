using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdPlanGetModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportAdPlanGetModel : AlipayObject
    {
        /// <summary>
        /// 广告系统的用户ID
        /// </summary>
        [JsonPropertyName("ad_user_id")]
        public long AdUserId { get; set; }

        /// <summary>
        /// 通过API新建计划，获得的计划ID
        /// </summary>
        [JsonPropertyName("plan_id")]
        public long PlanId { get; set; }
    }
}
