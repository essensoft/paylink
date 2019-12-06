using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OutboundOrderLine Data Structure.
    /// </summary>
    public class OutboundOrderLine : AlipayObject
    {
        /// <summary>
        /// 批次编号
        /// </summary>
        [JsonPropertyName("batch_code")]
        public string BatchCode { get; set; }

        /// <summary>
        /// 货品过期日期
        /// </summary>
        [JsonPropertyName("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 货品编码
        /// </summary>
        [JsonPropertyName("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// ZP("正品"),CC("残次"), JS("机损"),XS("箱损"),ZT("在途库存");
        /// </summary>
        [JsonPropertyName("inventory_type")]
        public string InventoryType { get; set; }

        /// <summary>
        /// 计划出库量
        /// </summary>
        [JsonPropertyName("plan_quantity")]
        public long PlanQuantity { get; set; }

        /// <summary>
        /// 价格(单位元，保留2为小数)
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 货品生产日期
        /// </summary>
        [JsonPropertyName("product_date")]
        public string ProductDate { get; set; }

        /// <summary>
        /// 备注信息。
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }
    }
}
