using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandTradeorderRefundResponse.
    /// </summary>
    public class AntMerchantExpandTradeorderRefundResponse : AlipayResponse
    {
        /// <summary>
        /// 买家ID
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 退款时间
        /// </summary>
        [JsonPropertyName("gmt_refund")]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 退款金额；单位：分
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public long RefundAmount { get; set; }

        /// <summary>
        /// 退款单ID
        /// </summary>
        [JsonPropertyName("refund_order_id")]
        public string RefundOrderId { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        [JsonPropertyName("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 卖家ID
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }
    }
}
