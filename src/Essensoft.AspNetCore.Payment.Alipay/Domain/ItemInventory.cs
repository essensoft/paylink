using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemInventory Data Structure.
    /// </summary>
    [Serializable]
    public class ItemInventory : AlipayObject
    {
        /// <summary>
        /// 商品库存扩展属性
        /// </summary>
        [JsonProperty("ext_prop")]
        public string ExtProp { get; set; }

        /// <summary>
        /// 外部商品ID
        /// </summary>
        [JsonProperty("external_item_id")]
        public string ExternalItemId { get; set; }

        /// <summary>
        /// 商品库存数量
        /// </summary>
        [JsonProperty("inventory")]
        public long Inventory { get; set; }
    }
}
