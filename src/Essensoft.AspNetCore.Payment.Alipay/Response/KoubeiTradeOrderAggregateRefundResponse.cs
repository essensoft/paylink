using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiTradeOrderAggregateRefundResponse.
    /// </summary>
    public class KoubeiTradeOrderAggregateRefundResponse : AlipayResponse
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
        /// PROCESSING - 退款处理中 FAILED - 退款失败
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 外部订单号； 同一商户下必须唯一，用来控制幂等
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 外部退款单号 ； 同一商户下必须唯一，用来控制幂等
        /// </summary>
        [JsonPropertyName("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 实收金额
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 用户实付金额
        /// </summary>
        [JsonPropertyName("refund_buyer_amount")]
        public string RefundBuyerAmount { get; set; }

        /// <summary>
        /// 平台优惠金额
        /// </summary>
        [JsonPropertyName("refund_discount_amount")]
        public string RefundDiscountAmount { get; set; }

        /// <summary>
        /// 商家优惠金额
        /// </summary>
        [JsonPropertyName("refund_mdiscount_amount")]
        public string RefundMdiscountAmount { get; set; }

        /// <summary>
        /// 口碑退款单ID
        /// </summary>
        [JsonPropertyName("refund_order_id")]
        public string RefundOrderId { get; set; }

        /// <summary>
        /// 实际退款金额
        /// </summary>
        [JsonPropertyName("refund_real_amount")]
        public string RefundRealAmount { get; set; }

        /// <summary>
        /// 支付宝/微信交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
