using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

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
        [JsonProperty("report_list")]
        public List<AlisisReport> ReportList { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }
}
