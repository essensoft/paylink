using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdPlanCertifyModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportAdPlanCertifyModel : AlipayObject
    {
        /// <summary>
        /// 广告系统用户ID
        /// </summary>
        [JsonPropertyName("ad_user_id")]
        public long AdUserId { get; set; }

        /// <summary>
        /// 广告计划ID
        /// </summary>
        [JsonPropertyName("plan_id")]
        public long PlanId { get; set; }
    }
}
