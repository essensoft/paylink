using System.Text.Json.Serialization;

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
        [JsonPropertyName("budget_id")]
        public string BudgetId { get; set; }

        /// <summary>
        /// 预算追加支付确认链接
        /// </summary>
        [JsonPropertyName("confirm_uri")]
        public string ConfirmUri { get; set; }

        /// <summary>
        /// 资金订单号
        /// </summary>
        [JsonPropertyName("fund_order_no")]
        public string FundOrderNo { get; set; }
    }
}
