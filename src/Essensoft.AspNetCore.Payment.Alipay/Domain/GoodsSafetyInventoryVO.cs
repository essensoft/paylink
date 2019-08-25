using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GoodsSafetyInventoryVO Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsSafetyInventoryVO : AlipayObject
    {
        /// <summary>
        /// 2018-08-18
        /// </summary>
        [JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 货品编码
        /// </summary>
        [JsonProperty("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 历史平均每天销售
        /// </summary>
        [JsonProperty("historical_daily_sales")]
        public string HistoricalDailySales { get; set; }

        /// <summary>
        /// 最小购买数量
        /// </summary>
        [JsonProperty("min_order_num")]
        public string MinOrderNum { get; set; }

        /// <summary>
        /// 采购周期
        /// </summary>
        [JsonProperty("purchase_cycle")]
        public string PurchaseCycle { get; set; }

        /// <summary>
        /// 安全库存
        /// </summary>
        [JsonProperty("safety_inventory")]
        public string SafetyInventory { get; set; }

        /// <summary>
        /// 目标库存
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
