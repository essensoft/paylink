using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandTradeorderRefundModel Data Structure.
    /// </summary>
    public class AntMerchantExpandTradeorderRefundModel : AlipayObject
    {
        /// <summary>
        /// 订单ID；订单唯一标识
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 退款理由
        /// </summary>
        [JsonPropertyName("refund_reason")]
        public string RefundReason { get; set; }
    }
}
