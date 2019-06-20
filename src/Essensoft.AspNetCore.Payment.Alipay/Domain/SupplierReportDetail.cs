using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SupplierReportDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SupplierReportDetail : AlipayObject
    {
        /// <summary>
        /// 批次编码
        /// </summary>
        [JsonProperty("batch_code")]
        public string BatchCode { get; set; }

        /// <summary>
        /// 过期日期
        /// </summary>
        [JsonProperty("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 货品编码
        /// </summary>
        [JsonProperty("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 库存类型
        /// </summary>
        [JsonProperty("inventory_type")]
        public string InventoryType { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        [JsonProperty("production_date")]
        public string ProductionDate { get; set; }

        /// <summary>
        /// 差异数量,为正整数
        /// </summary>
        [JsonProperty("quantity_diff")]
        public long QuantityDiff { get; set; }

        /// <summary>
        /// 盘盈/盘亏(increase/reduce)
        /// </summary>
        [JsonProperty("report_type")]
        public string ReportType { get; set; }

        /// <summary>
        /// 供货商盘点单明细id
        /// </summary>
        [JsonProperty("supplier_report_detail_id")]
        public string SupplierReportDetailId { get; set; }

        /// <summary>
        /// 供货商盘点单id
        /// </summary>
        [JsonProperty("supplier_report_id")]
        public string SupplierReportId { get; set; }
    }
}
