using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialGiftOrderRefundModel Data Structure.
    /// </summary>
    public class AlipaySocialGiftOrderRefundModel : AlipayObject
    {
        /// <summary>
        /// 商户再送礼平台的唯一ID，用于标识具体的调用业务方，需要先在送礼平台进行业务类型的分配之后才看使用。
        /// </summary>
        [JsonPropertyName("mid")]
        public string Mid { get; set; }

        /// <summary>
        /// 对应送礼平台的主订单ID，可根据此进行订单查询
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 部分退款金额，该金额当退款类型为部分退款的时候，是必填的。部分退款以为这退部分金额。注意目前该接口只支持单次退款，即只允许单笔订单退一次。
        /// </summary>
        [JsonPropertyName("refund_price")]
        public string RefundPrice { get; set; }

        /// <summary>
        /// 退款类型：  REFUND_ALL：全额退款， 取订单金额进行全额退款  REFUND_PARTLY：部分退款  默认为：REFUND_ALL
        /// </summary>
        [JsonPropertyName("refund_type")]
        public string RefundType { get; set; }
    }
}
