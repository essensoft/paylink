using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ItemConsultRequest Data Structure.
    /// </summary>
    public class ItemConsultRequest : AlipayObject
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品单价，单位为元，最多2位小数
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonPropertyName("quantity")]
        public string Quantity { get; set; }
    }
}
