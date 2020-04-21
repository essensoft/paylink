using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffInventoryrealtimeSyncModel Data Structure.
    /// </summary>
    public class KoubeiSalesKbassetStuffInventoryrealtimeSyncModel : AlipayObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 库存时间
        /// </summary>
        [JsonPropertyName("inventory_time")]
        public string InventoryTime { get; set; }

        /// <summary>
        /// 库存明细
        /// </summary>
        [JsonPropertyName("items")]
        public List<InventoryItem> Items { get; set; }
    }
}
