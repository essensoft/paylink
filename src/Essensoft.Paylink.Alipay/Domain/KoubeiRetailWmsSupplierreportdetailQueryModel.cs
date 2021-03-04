using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsSupplierreportdetailQueryModel Data Structure.
    /// </summary>
    public class KoubeiRetailWmsSupplierreportdetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 供货商盘点单id
        /// </summary>
        [JsonPropertyName("supplier_report_id")]
        public string SupplierReportId { get; set; }
    }
}
