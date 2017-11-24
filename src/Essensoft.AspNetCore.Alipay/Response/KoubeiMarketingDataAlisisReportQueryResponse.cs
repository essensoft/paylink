using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingDataAlisisReportQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataAlisisReportQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 报表数据
        /// </summary>
        [JsonProperty("report_data")]
        public List<AlisisReportRow> ReportData { get; set; }
    }
}
