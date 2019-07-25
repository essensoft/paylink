using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InventoryItem Data Structure.
    /// </summary>
    [Serializable]
    public class InventoryItem : AlipayObject
    {
        /// <summary>
        /// 可用库存
        /// </summary>
        [JsonProperty("available_qty")]
        public long AvailableQty { get; set; }

        /// <summary>
        /// 扩展库存
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 在库库存
        /// </summary>
        [JsonProperty("on_hand_qty")]
        public long OnHandQty { get; set; }

        /// <summary>
        /// sku号
        /// </summary>
        [JsonProperty("sku_no")]
        public string SkuNo { get; set; }

        /// <summary>
        /// 总库存
        /// </summary>
        [JsonProperty("total_qty")]
        public long TotalQty { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonProperty("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
