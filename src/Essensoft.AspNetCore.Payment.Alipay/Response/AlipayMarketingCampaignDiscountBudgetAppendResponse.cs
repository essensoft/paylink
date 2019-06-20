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

        /// <summary>
        /// 预算追加支付确认链接
        /// </summary>
        [JsonProperty("confirm_uri")]
        public string ConfirmUri { get; set; }

        /// <summary>
        /// 资金订单号
        /// </summary>
        [JsonProperty("fund_order_no")]
        public string FundOrderNo { get; set; }
    }
}
