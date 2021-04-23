using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceSportsVenueOrderQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceSportsVenueOrderQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝业务订单唯一ID
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 服务商内部唯一订单号
        /// </summary>
        [JsonPropertyName("out_order_id")]
        public string OutOrderId { get; set; }
    }
}
