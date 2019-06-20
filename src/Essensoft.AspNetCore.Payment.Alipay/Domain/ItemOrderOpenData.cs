using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemOrderOpenData Data Structure.
    /// </summary>
    [Serializable]
    public class ItemOrderOpenData : AlipayObject
    {
        /// <summary>
        /// 商品订单扩展信息
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 订单修改时间
        /// </summary>
        [JsonProperty("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品订单ID
        /// </summary>
        [JsonProperty("item_order_id")]
        public string ItemOrderId { get; set; }

        /// <summary>
        /// 关联主订单ID
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 实付金额；单位：分
        /// </summary>
        [JsonProperty("real_amount")]
        public long RealAmount { get; set; }

        /// <summary>
        /// 商品SKUID
        /// </summary>
        [JsonProperty("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 商品快照ID
        /// </summary>
        [JsonProperty("snapshot_id")]
        public string SnapshotId { get; set; }

        /// <summary>
        /// 商品订单状态；INIT(初始化)、WAIT_PAY(待支付)、PAID(已支付)、SUCCESS_FINISHED(已完结)、REFUNDED(已退款)、CLOSED(已关闭)
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商户补贴金额；单位：分
        /// </summary>
        [JsonProperty("subsidy_amount")]
        public long SubsidyAmount { get; set; }

        /// <summary>
        /// 商品单价；单位：分
        /// </summary>
        [JsonProperty("unit_price")]
        public long UnitPrice { get; set; }
    }
}
