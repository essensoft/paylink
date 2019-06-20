using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GoodsSafetyInventory Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsSafetyInventory : AlipayObject
    {
        /// <summary>
        /// 货品编码
        /// </summary>
        [JsonProperty("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 最小采购量
        /// </summary>
        [JsonProperty("min_order_num")]
        public string MinOrderNum { get; set; }

        /// <summary>
        /// 采购周期（单位天）
        /// </summary>
        [JsonProperty("purchase_cycle")]
        public string PurchaseCycle { get; set; }

        /// <summary>
        /// 安全库存数量
        /// </summary>
        [JsonProperty("safety_inventory")]
        public string SafetyInventory { get; set; }

        /// <summary>
        /// 目标库存数量
        /// </summary>
        [JsonProperty("target_inventory")]
        public string TargetInventory { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonProperty("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
