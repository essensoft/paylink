using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
        [XmlArray("report_data")]
        [XmlArrayItem("alisis_report_row")]
        public List<AlisisReportRow> ReportData { get; set; }
    }
}
