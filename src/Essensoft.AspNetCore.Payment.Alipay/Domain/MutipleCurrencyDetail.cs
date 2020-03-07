using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MutipleCurrencyDetail Data Structure.
    /// </summary>
    public class MutipleCurrencyDetail : AlipayObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        [JsonPropertyName("payment_amount")]
        public string PaymentAmount { get; set; }

        /// <summary>
        /// 支付币种
        /// </summary>
        [JsonPropertyName("payment_currency")]
        public string PaymentCurrency { get; set; }

        /// <summary>
        /// 清算金额
        /// </summary>
        [JsonPropertyName("settlement_amount")]
        public string SettlementAmount { get; set; }

        /// <summary>
        /// 清算币种
        /// </summary>
        [JsonPropertyName("settlement_currency")]
        public string SettlementCurrency { get; set; }

        /// <summary>
        /// 转账金额
        /// </summary>
        [JsonPropertyName("trans_amount")]
        public string TransAmount { get; set; }

        /// <summary>
        /// 转账币种
        /// </summary>
        [JsonPropertyName("trans_currency")]
        public string TransCurrency { get; set; }
    }
}
