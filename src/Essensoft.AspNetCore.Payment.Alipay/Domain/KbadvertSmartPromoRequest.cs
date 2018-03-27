using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbadvertSmartPromoRequest Data Structure.
    /// </summary>
    public class KbadvertSmartPromoRequest : AlipayObject
    {
        /// <summary>
        /// 智能营销分组ID
        /// </summary>
        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 智能营销方案ID
        /// </summary>
        [JsonProperty("plan_id")]
        public string PlanId { get; set; }
    }
}
