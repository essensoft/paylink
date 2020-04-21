using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountBudgetAppendModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignDiscountBudgetAppendModel : AlipayObject
    {
        /// <summary>
        /// 预算ID
        /// </summary>
        [JsonPropertyName("budget_id")]
        public string BudgetId { get; set; }

        /// <summary>
        /// 追加后的预算总金额（注意：是追加后的预算总金额，不是在原基础上追加的金额），单位：元
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }
    }
}
