using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiRetailWmsSupplierreportdetailQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsSupplierreportdetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 盘点单信息
        /// </summary>
        [JsonPropertyName("supplier_report")]
        public SupplierReport SupplierReport { get; set; }

        /// <summary>
        /// 盘点单明细记录
        /// </summary>
        [JsonPropertyName("supplier_report_details")]
        public List<SupplierReportDetail> SupplierReportDetails { get; set; }
    }
}
