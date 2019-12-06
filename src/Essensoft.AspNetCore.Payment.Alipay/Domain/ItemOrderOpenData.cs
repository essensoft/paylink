using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemOrderOpenData Data Structure.
    /// </summary>
    public class ItemOrderOpenData : AlipayObject
    {
        /// <summary>
        /// 商品订单扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 订单修改时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品订单ID
        /// </summary>
        [JsonPropertyName("item_order_id")]
        public string ItemOrderId { get; set; }

        /// <summary>
        /// 关联主订单ID
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 实付金额；单位：分
        /// </summary>
        [JsonPropertyName("real_amount")]
        public long RealAmount { get; set; }

        /// <summary>
        /// 商品SKUID
        /// </summary>
        [JsonPropertyName("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 商品快照ID
        /// </summary>
        [JsonPropertyName("snapshot_id")]
        public string SnapshotId { get; set; }

        /// <summary>
        /// 商品订单状态；INIT(初始化)、WAIT_PAY(待支付)、PAID(已支付)、SUCCESS_FINISHED(已完结)、REFUNDED(已退款)、CLOSED(已关闭)
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商户补贴金额；单位：分
        /// </summary>
        [JsonPropertyName("subsidy_amount")]
        public long SubsidyAmount { get; set; }

        /// <summary>
        /// 商品单价；单位：分
        /// </summary>
        [JsonPropertyName("unit_price")]
        public long UnitPrice { get; set; }
    }
}
