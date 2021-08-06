using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ApSumSummaryBillAmountDTO Data Structure.
    /// </summary>
    public class ApSumSummaryBillAmountDTO : AlipayObject
    {
        /// <summary>
        /// 账单金额
        /// </summary>
        [JsonPropertyName("bill_amount")]
        public MultiCurrencyMoneyOpenApi BillAmount { get; set; }

        /// <summary>
        /// 已出账金额
        /// </summary>
        [JsonPropertyName("checkout_amount")]
        public MultiCurrencyMoneyOpenApi CheckoutAmount { get; set; }

        /// <summary>
        /// 已确认金额
        /// </summary>
        [JsonPropertyName("confirmed_amount")]
        public MultiCurrencyMoneyOpenApi ConfirmedAmount { get; set; }

        /// <summary>
        /// 已结算金额
        /// </summary>
        [JsonPropertyName("settled_amount")]
        public MultiCurrencyMoneyOpenApi SettledAmount { get; set; }

        /// <summary>
        /// 结算总金额
        /// </summary>
        [JsonPropertyName("settling_amount")]
        public MultiCurrencyMoneyOpenApi SettlingAmount { get; set; }

        /// <summary>
        /// 待确认金额
        /// </summary>
        [JsonPropertyName("un_confirmed_amount")]
        public MultiCurrencyMoneyOpenApi UnConfirmedAmount { get; set; }

        /// <summary>
        /// 待结算金额
        /// </summary>
        [JsonPropertyName("un_settle_amount")]
        public MultiCurrencyMoneyOpenApi UnSettleAmount { get; set; }
    }
}
