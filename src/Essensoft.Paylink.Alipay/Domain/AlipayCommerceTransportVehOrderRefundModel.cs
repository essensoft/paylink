using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportVehOrderRefundModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportVehOrderRefundModel : AlipayObject
    {
        /// <summary>
        /// 车主系统订单号，商户订单同步到车主系统时，会在获取到此订单号。请注意，该订单号属于车主系统业务订单号。
        /// </summary>
        [JsonPropertyName("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 订单类型，使用时务必联系业务或解决方案。
        /// </summary>
        [JsonPropertyName("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 外部请求唯一号，代表一次退款申请，请求唯一且幂等
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 描述一个订单的退款原因
        /// </summary>
        [JsonPropertyName("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 订单退款子订单列表
        /// </summary>
        [JsonPropertyName("sub_order_refund_list")]
        public List<SubOrderRefundRequest> SubOrderRefundList { get; set; }

        /// <summary>
        /// 支付宝收单系统交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
