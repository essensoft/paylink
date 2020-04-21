using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbadvertSmartPromoResponse Data Structure.
    /// </summary>
    public class KbadvertSmartPromoResponse : AlipayObject
    {
        /// <summary>
        /// 智能营销分组ID
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 智能营销方案ID
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }
    }
}
