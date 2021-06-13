using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehOrderRefundResponse.
    /// </summary>
    public class AlipayCommerceTransportVehOrderRefundResponse : AlipayResponse
    {
        /// <summary>
        /// 退款金额
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 分润金额
        /// </summary>
        [JsonPropertyName("refund_applets_service_amount")]
        public string RefundAppletsServiceAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
