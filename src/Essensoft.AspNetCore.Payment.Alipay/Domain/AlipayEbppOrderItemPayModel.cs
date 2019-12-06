using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppOrderItemPayModel Data Structure.
    /// </summary>
    public class AlipayEbppOrderItemPayModel : AlipayObject
    {
        /// <summary>
        /// 支付宝侧对预下单订单项的唯一标识
        /// </summary>
        [JsonPropertyName("alipay_item_id")]
        public string AlipayItemId { get; set; }
    }
}
