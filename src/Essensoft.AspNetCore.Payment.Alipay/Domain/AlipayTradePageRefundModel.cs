using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradePageRefundModel Data Structure.
    /// </summary>
    public class AlipayTradePageRefundModel : AlipayObject
    {
        /// <summary>
        /// 退款场景。 信用退款传CREDIT_REFUND；
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [JsonPropertyName("extend_params")]
        public RefundExtendParams ExtendParams { get; set; }

        /// <summary>
        /// 商户的操作员编号
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 标识一次退款请求，同一笔交易多次退款需要保证唯一。
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 订单支付时传入的商户订单号,不能和 trade_no同时为空。
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 需要退款的金额，该金额不能大于订单金额,单位为元，支持两位小数。
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款的原因说明
        /// </summary>
        [JsonPropertyName("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 商户的门店编号
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 商户的终端编号
        /// </summary>
        [JsonPropertyName("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// 支付宝交易号，和商户订单号不能同时为空
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
