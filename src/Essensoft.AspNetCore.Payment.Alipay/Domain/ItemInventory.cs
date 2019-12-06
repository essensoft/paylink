using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemInventory Data Structure.
    /// </summary>
    public class ItemInventory : AlipayObject
    {
        /// <summary>
        /// 商品库存扩展属性
        /// </summary>
        [JsonPropertyName("ext_prop")]
        public string ExtProp { get; set; }

        /// <summary>
        /// 外部商品ID
        /// </summary>
        [JsonPropertyName("external_item_id")]
        public string ExternalItemId { get; set; }

        /// <summary>
        /// 商品库存数量
        /// </summary>
        [JsonPropertyName("inventory")]
        public long Inventory { get; set; }
    }
}
