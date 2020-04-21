using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiTradeOrderRefundQueryResponse.
    /// </summary>
    public class KoubeiTradeOrderRefundQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 退款成功时间
        /// </summary>
        [JsonPropertyName("gmt_refund_time")]
        public string GmtRefundTime { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 外部退款单号
        /// </summary>
        [JsonPropertyName("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 退款总金额
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 用户实退金额
        /// </summary>
        [JsonPropertyName("refund_buyer_amount")]
        public string RefundBuyerAmount { get; set; }

        /// <summary>
        /// 退平台优惠金额
        /// </summary>
        [JsonPropertyName("refund_discount_amount")]
        public string RefundDiscountAmount { get; set; }

        /// <summary>
        /// 退商家优惠金额
        /// </summary>
        [JsonPropertyName("refund_mdiscount_amount")]
        public string RefundMdiscountAmount { get; set; }

        /// <summary>
        /// 退款单状态  SUCCESS - 成功 PROCESSING - 受理中 FAILED - 失败
        /// </summary>
        [JsonPropertyName("refund_status")]
        public string RefundStatus { get; set; }
    }
}
