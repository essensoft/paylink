using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Inventory Data Structure.
    /// </summary>
    public class Inventory : AlipayObject
    {
        /// <summary>
        /// 批次编号
        /// </summary>
        [JsonPropertyName("batch_code")]
        public string BatchCode { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonPropertyName("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 扩展字段，json格式
        /// </summary>
        [JsonPropertyName("extend_props")]
        public string ExtendProps { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 货品编码
        /// </summary>
        [JsonPropertyName("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 货品类型：ZP("正品"), CC("残次"), JS("机损"),  XS("箱损"),ZT("在途库存")
        /// </summary>
        [JsonPropertyName("inventory_type")]
        public string InventoryType { get; set; }

        /// <summary>
        /// 锁定数量
        /// </summary>
        [JsonPropertyName("lock_quantity")]
        public long LockQuantity { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        [JsonPropertyName("product_date")]
        public string ProductDate { get; set; }

        /// <summary>
        /// 可用数量
        /// </summary>
        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 实际数量
        /// </summary>
        [JsonPropertyName("real_quantity")]
        public long RealQuantity { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonPropertyName("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
