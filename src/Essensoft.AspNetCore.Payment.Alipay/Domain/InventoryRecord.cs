using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InventoryRecord Data Structure.
    /// </summary>
    public class InventoryRecord : AlipayObject
    {
        /// <summary>
        /// 可用库存变更之后
        /// </summary>
        [JsonPropertyName("after_modify_lock_quantity")]
        public long AfterModifyLockQuantity { get; set; }

        /// <summary>
        /// 可用库存变更之后
        /// </summary>
        [JsonPropertyName("after_modify_quantity")]
        public long AfterModifyQuantity { get; set; }

        /// <summary>
        /// 批次号
        /// </summary>
        [JsonPropertyName("batch_code")]
        public string BatchCode { get; set; }

        /// <summary>
        /// 占用库存变更之前
        /// </summary>
        [JsonPropertyName("before_modify_lock_quantity")]
        public string BeforeModifyLockQuantity { get; set; }

        /// <summary>
        /// 可用库存变更之前
        /// </summary>
        [JsonPropertyName("before_modify_quantity")]
        public long BeforeModifyQuantity { get; set; }

        /// <summary>
        /// 占用库存
        /// </summary>
        [JsonPropertyName("diff_lock_quantity")]
        public long DiffLockQuantity { get; set; }

        /// <summary>
        /// 可用库存变化量
        /// </summary>
        [JsonPropertyName("diff_quantity")]
        public long DiffQuantity { get; set; }

        /// <summary>
        /// 过期日期
        /// </summary>
        [JsonPropertyName("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        [JsonPropertyName("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 库存类型（ZP=正品, CC=残次,JS=机损, XS= 箱损, ZT=在途库存）
        /// </summary>
        [JsonPropertyName("inventory_type")]
        public string InventoryType { get; set; }

        /// <summary>
        /// 操作类型（INBOUND＝入库  OUTBOUND＝出库）
        /// </summary>
        [JsonPropertyName("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [JsonPropertyName("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        [JsonPropertyName("product_date")]
        public string ProductDate { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonPropertyName("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
