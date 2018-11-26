using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsSupplierreportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsSupplierreportQueryModel : AlipayObject
    {
        /// <summary>
        /// 下单时间上区间
        /// </summary>
        [JsonProperty("end_time")]
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("page_no")]
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [JsonProperty("page_size")]
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 下单时间下区间
        /// </summary>
        [JsonProperty("start_time")]
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 状态，INT:单据未完成，FINISHED:单据已完成
        /// </summary>
        [JsonProperty("state")]
        [XmlElement("state")]
        public string State { get; set; }

        /// <summary>
        /// 供货商盘点单id
        /// </summary>
        [JsonProperty("supplier_report_id")]
        [XmlElement("supplier_report_id")]
        public string SupplierReportId { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonProperty("warehouse_code")]
        [XmlElement("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
