using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountBudgetAppendResponse.
    /// </summary>
    public class AlipayMarketingCampaignDiscountBudgetAppendResponse : AlipayResponse
    {
        /// <summary>
        /// 预算ID
        /// </summary>
        [JsonProperty("budget_id")]
        public string BudgetId { get; set; }
    }
}
