using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceSportsVenueOrderRefundModel Data Structure.
    /// </summary>
    public class AlipayCommerceSportsVenueOrderRefundModel : AlipayObject
    {
        /// <summary>
        /// 退款原因
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
        /// 退款金额(单位：元)
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public string RefundAmount { get; set; }
    }
}
