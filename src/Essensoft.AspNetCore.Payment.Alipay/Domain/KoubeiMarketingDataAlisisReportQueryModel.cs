using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataAlisisReportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataAlisisReportQueryModel : AlipayObject
    {
        /// <summary>
        /// 报表查询过滤条件
        /// </summary>
        [JsonProperty("conditions")]
        [XmlArray("conditions")]
        [XmlArrayItem("report_query_condition")]
        public List<ReportQueryCondition> Conditions { get; set; }

        /// <summary>
        /// 报表唯一标识
        /// </summary>
        [JsonProperty("report_uk")]
        [XmlElement("report_uk")]
        public string ReportUk { get; set; }
    }
}
