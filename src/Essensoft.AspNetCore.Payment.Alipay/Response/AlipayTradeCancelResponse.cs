using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeCancelResponse.
    /// </summary>
    public class AlipayTradeCancelResponse : AlipayResponse
    {
        /// <summary>
        /// 本次撤销触发的交易动作  close：关闭交易，无退款  refund：产生了退款
        /// </summary>
        [JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// 当撤销产生了退款时，返回退款时间；  默认不返回该信息，需与支付宝约定后配置返回；
        /// </summary>
        [JsonProperty("gmt_refund_pay")]
        public string GmtRefundPay { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 当撤销产生了退款时，返回的退款清算编号，用于清算对账使用；  只在银行间联交易场景下返回该信息；
        /// </summary>
        [JsonProperty("refund_settlement_id")]
        public string RefundSettlementId { get; set; }

        /// <summary>
        /// 是否需要重试
        /// </summary>
        [JsonProperty("retry_flag")]
        public string RetryFlag { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
