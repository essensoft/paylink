using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialGiftOrderRefundResponse.
    /// </summary>
    public class AlipaySocialGiftOrderRefundResponse : AlipayResponse
    {
        /// <summary>
        /// 本次操作的订单id，与该接口入参order_id一致
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }
    }
}
