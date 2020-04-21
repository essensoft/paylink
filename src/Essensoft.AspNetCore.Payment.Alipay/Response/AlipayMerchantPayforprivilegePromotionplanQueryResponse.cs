using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegePromotionplanQueryResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegePromotionplanQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 充享惠方案信息，返回之前创建的充享惠方案信息，方案不存在或者无权限返回空
        /// </summary>
        [JsonPropertyName("promotion_plan")]
        public PayForPrivilegePromotionPlanInfo PromotionPlan { get; set; }
    }
}
