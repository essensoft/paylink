using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegePromotionplanCreateResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegePromotionplanCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 充享惠方案，当前接口创建的充享惠方案
        /// </summary>
        [JsonPropertyName("promotion_plan")]
        public PayForPrivilegePromotionPlanInfo PromotionPlan { get; set; }
    }
}
