using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GoodsSafetyInventory Data Structure.
    /// </summary>
    public class GoodsSafetyInventory : AlipayObject
    {
        /// <summary>
        /// 货品编码
        /// </summary>
        [JsonPropertyName("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 最小采购量
        /// </summary>
        [JsonPropertyName("min_order_num")]
        public string MinOrderNum { get; set; }

        /// <summary>
        /// 采购周期（单位天）
        /// </summary>
        [JsonPropertyName("purchase_cycle")]
        public string PurchaseCycle { get; set; }

        /// <summary>
        /// 安全库存数量
        /// </summary>
        [JsonPropertyName("safety_inventory")]
        public string SafetyInventory { get; set; }

        /// <summary>
        /// 目标库存数量
        /// </summary>
        [JsonPropertyName("target_inventory")]
        public string TargetInventory { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonPropertyName("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
