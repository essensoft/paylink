using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayTradeOverseasSettleResponse.
    /// </summary>
    public class AlipayTradeOverseasSettleResponse : AlipayResponse
    {
        /// <summary>
        /// 本笔跨境结算使用的汇率，精度 8 位小数
        /// </summary>
        [JsonPropertyName("exchange_rate")]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// 本次跨境结算的实际结算外币金额
        /// </summary>
        [JsonPropertyName("foreign_settle_amount")]
        public string ForeignSettleAmount { get; set; }

        /// <summary>
        /// 本笔跨境结算实际结算的外币币种
        /// </summary>
        [JsonPropertyName("foreign_settle_currency")]
        public string ForeignSettleCurrency { get; set; }

        /// <summary>
        /// 请求流水号，开发者自行生成并保证唯一性，作为业务幂等性控制
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 本次跨境结算的实际结算人民币金额
        /// </summary>
        [JsonPropertyName("settle_amount")]
        public string SettleAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
