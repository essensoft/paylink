using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SubOrderRefundRequest Data Structure.
    /// </summary>
    public class SubOrderRefundRequest : AlipayObject
    {
        /// <summary>
        /// 子订单退款金额
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款分润基数。注意：如果不传，计收费系统默认分润基数为该子订单所属主订单的总金额，当传错或不传，可能会导致不符合预期，该规则请联系解释业务或解决方案。
        /// </summary>
        [JsonPropertyName("refund_applets_service_amount")]
        public string RefundAppletsServiceAmount { get; set; }

        /// <summary>
        /// 该子订单的退款说明。如果无说明，请填入：无
        /// </summary>
        [JsonPropertyName("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 车主系统退款子订单编号，商户同步订单到车主系统后，同步响应结果的子订单编号
        /// </summary>
        [JsonPropertyName("sub_alipay_order_no")]
        public string SubAlipayOrderNo { get; set; }
    }
}
