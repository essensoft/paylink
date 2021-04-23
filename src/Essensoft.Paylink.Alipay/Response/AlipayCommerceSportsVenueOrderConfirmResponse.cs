using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceSportsVenueOrderConfirmResponse.
    /// </summary>
    public class AlipayCommerceSportsVenueOrderConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝业务订单唯一ID
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单状态 pay_proc - 待支付 pay_succ - 已支付 refund_succ - 已退款 closed - 已关闭
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }
    }
}
