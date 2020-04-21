using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeCreditFinancePayResponse.
    /// </summary>
    public class AlipayTradeCreditFinancePayResponse : AlipayResponse
    {
        /// <summary>
        /// 本次支付的金额，单位为元；精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 币种，CNY
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 本次支付的处理状态 SUCCESS FAIL
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 本次金融付款对应的交易的交易买家
        /// </summary>
        [JsonPropertyName("trade_buyer_id")]
        public string TradeBuyerId { get; set; }

        /// <summary>
        /// 本次金融付款对应的交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
