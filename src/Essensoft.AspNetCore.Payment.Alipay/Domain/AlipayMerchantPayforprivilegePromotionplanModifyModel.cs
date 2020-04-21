using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantPayforprivilegePromotionplanModifyModel Data Structure.
    /// </summary>
    public class AlipayMerchantPayforprivilegePromotionplanModifyModel : AlipayObject
    {
        /// <summary>
        /// 充享惠方案的结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 充享惠方案ID，通过创建接口创建的ID
        /// </summary>
        [JsonPropertyName("promotion_plan_id")]
        public string PromotionPlanId { get; set; }

        /// <summary>
        /// 充享惠方案开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 充享惠方案的状态，ENABLED(启用), DISABLED(停用)
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
