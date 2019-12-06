using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InventoryItem Data Structure.
    /// </summary>
    public class InventoryItem : AlipayObject
    {
        /// <summary>
        /// 可用库存
        /// </summary>
        [JsonPropertyName("available_qty")]
        public long AvailableQty { get; set; }

        /// <summary>
        /// 扩展库存
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 在库库存
        /// </summary>
        [JsonPropertyName("on_hand_qty")]
        public long OnHandQty { get; set; }

        /// <summary>
        /// sku号
        /// </summary>
        [JsonPropertyName("sku_no")]
        public string SkuNo { get; set; }

        /// <summary>
        /// 总库存
        /// </summary>
        [JsonPropertyName("total_qty")]
        public long TotalQty { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonPropertyName("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
