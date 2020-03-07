using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingOrderRefundResponse.
    /// </summary>
    public class AlipayEcoMycarParkingOrderRefundResponse : AlipayResponse
    {
        /// <summary>
        /// 代扣时返回的支付宝支付交易流水号，系统唯一
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部申请退款请求流水，ISV唯一
        /// </summary>
        [JsonPropertyName("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 本次退款金额，保留小数点后两位
        /// </summary>
        [JsonPropertyName("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 支付宝退款流水
        /// </summary>
        [JsonPropertyName("refund_no")]
        public string RefundNo { get; set; }
    }
}
