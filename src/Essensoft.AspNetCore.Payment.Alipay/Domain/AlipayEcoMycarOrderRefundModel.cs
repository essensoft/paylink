using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarOrderRefundModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarOrderRefundModel : AlipayObject
    {
        /// <summary>
        /// 退款交易编号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 退款金额（单位：元）
        /// </summary>
        [JsonPropertyName("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [JsonPropertyName("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退款请求编号，针对一笔退款需保证唯一
        /// </summary>
        [JsonPropertyName("req_no")]
        public string ReqNo { get; set; }
    }
}
