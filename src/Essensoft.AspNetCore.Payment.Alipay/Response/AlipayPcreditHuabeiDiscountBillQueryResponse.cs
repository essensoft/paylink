using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiDiscountBillQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiDiscountBillQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 外部交易号
        /// </summary>
        [JsonPropertyName("charge_no")]
        public string ChargeNo { get; set; }

        /// <summary>
        /// 分期服务费
        /// </summary>
        [JsonPropertyName("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("pay_trade_no")]
        public string PayTradeNo { get; set; }

        /// <summary>
        /// 账单交易金额
        /// </summary>
        [JsonPropertyName("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [JsonPropertyName("trade_time")]
        public string TradeTime { get; set; }
    }
}
