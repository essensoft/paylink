using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegePromotionplanModifyResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegePromotionplanModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 充值方案信息，返回修改后的充值方案信息
        /// </summary>
        [JsonPropertyName("promotion_plan")]
        public PayForPrivilegePromotionPlanInfo PromotionPlan { get; set; }
    }
}
