using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsInventoryrecordQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsInventoryrecordQueryModel : AlipayObject
    {
        /// <summary>
        /// 批次号
        /// </summary>
        [JsonProperty("batch_code")]
        public string BatchCode { get; set; }

        /// <summary>
        /// 出入库截止时间
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

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
        /// 操作人信息
        /// </summary>
        [JsonProperty("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 库存操作类型（INBOUND＝入库，OUTBOUND＝出库）
        /// </summary>
        [JsonProperty("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [JsonProperty("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 页码（默认值为1，必须为正整数）
        /// </summary>
        [JsonProperty("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 页面大小（最小1，默认20，最大100）
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 出入库开始时间
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonProperty("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
