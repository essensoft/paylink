using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InventoryRecord Data Structure.
    /// </summary>
    [Serializable]
    public class InventoryRecord : AlipayObject
    {
        /// <summary>
        /// 可用库存变更之后
        /// </summary>
        [JsonProperty("after_modify_lock_quantity")]
        public long AfterModifyLockQuantity { get; set; }

        /// <summary>
        /// 可用库存变更之后
        /// </summary>
        [JsonProperty("after_modify_quantity")]
        public long AfterModifyQuantity { get; set; }

        /// <summary>
        /// 批次号
        /// </summary>
        [JsonProperty("batch_code")]
        public string BatchCode { get; set; }

        /// <summary>
        /// 占用库存变更之前
        /// </summary>
        [JsonProperty("before_modify_lock_quantity")]
        public string BeforeModifyLockQuantity { get; set; }

        /// <summary>
        /// 可用库存变更之前
        /// </summary>
        [JsonProperty("before_modify_quantity")]
        public long BeforeModifyQuantity { get; set; }

        /// <summary>
        /// 占用库存
        /// </summary>
        [JsonProperty("diff_lock_quantity")]
        public long DiffLockQuantity { get; set; }

        /// <summary>
        /// 可用库存变化量
        /// </summary>
        [JsonProperty("diff_quantity")]
        public long DiffQuantity { get; set; }

        /// <summary>
        /// 过期日期
        /// </summary>
        [JsonProperty("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        [JsonProperty("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 库存类型（ZP=正品, CC=残次,JS=机损, XS= 箱损, ZT=在途库存）
        /// </summary>
        [JsonProperty("inventory_type")]
        public string InventoryType { get; set; }

        /// <summary>
        /// 操作类型（INBOUND＝入库  OUTBOUND＝出库）
        /// </summary>
        [JsonProperty("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [JsonProperty("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        [JsonProperty("product_date")]
        public string ProductDate { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonProperty("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
