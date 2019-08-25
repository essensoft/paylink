using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffInventoryrealtimeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiSalesKbassetStuffInventoryrealtimeSyncModel : AlipayObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 库存时间
        /// </summary>
        [JsonProperty("inventory_time")]
        public string InventoryTime { get; set; }

        /// <summary>
        /// 库存明细
        /// </summary>
        [JsonProperty("items")]
        public List<InventoryItem> Items { get; set; }
    }
}
