using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceSportsVenueOrderRefundResponse.
    /// </summary>
    public class AlipayCommerceSportsVenueOrderRefundResponse : AlipayResponse
    {
        /// <summary>
        /// 操作描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 支付宝业务订单唯一ID
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 服务商内部唯一订单号
        /// </summary>
        [JsonPropertyName("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 退款结果 refund_succ -退款成功 refund_fail -退款失败
        /// </summary>
        [JsonPropertyName("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 支付宝退款单号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
