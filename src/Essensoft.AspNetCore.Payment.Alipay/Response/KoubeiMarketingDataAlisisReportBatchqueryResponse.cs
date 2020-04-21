using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingDataAlisisReportBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingDataAlisisReportBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 报表列表信息
        /// </summary>
        [JsonPropertyName("report_list")]
        public List<AlisisReport> ReportList { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonPropertyName("total_count")]
        public string TotalCount { get; set; }
    }
}
