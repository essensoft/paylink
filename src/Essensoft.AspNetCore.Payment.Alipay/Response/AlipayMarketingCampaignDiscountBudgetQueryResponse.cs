using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountBudgetQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignDiscountBudgetQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 预算ID
        /// </summary>
        [JsonPropertyName("budget_id")]
        public string BudgetId { get; set; }

        /// <summary>
        /// 预算剩余冻结金额(元)
        /// </summary>
        [JsonPropertyName("freeze_amount")]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// 预算已回收退回保证金账户金额(元)
        /// </summary>
        [JsonPropertyName("recycle_amount")]
        public string RecycleAmount { get; set; }

        /// <summary>
        /// 交易已退款金额(元)
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 预算总金额(元)
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 交易已使用金额(元)
        /// </summary>
        [JsonPropertyName("used_amount")]
        public string UsedAmount { get; set; }
    }
}
