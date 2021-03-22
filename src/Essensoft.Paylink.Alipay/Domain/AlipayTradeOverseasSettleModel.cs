using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeOverseasSettleModel Data Structure.
    /// </summary>
    public class AlipayTradeOverseasSettleModel : AlipayObject
    {
        /// <summary>
        /// 跨境结算的人民币金额，单位为元；等于交易金额 (实际为实收金额)，加上净补差金额，减去已退款金额，减去净收费金额，再减去净分账金额，
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 跨境结算的外币币种
        /// </summary>
        [JsonPropertyName("foreign_settle_currency")]
        public string ForeignSettleCurrency { get; set; }

        /// <summary>
        /// 外部请求号，开发者自行生成并保证唯一性，作为业务幂等性控制
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
