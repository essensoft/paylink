using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataCustomreportSaveModel : AlipayObject
    {
        /// <summary>
        /// 自定义报表规则条件信息
        /// </summary>
        [JsonProperty("report_condition_info")]
        [XmlElement("report_condition_info")]
        public CustomReportCondition ReportConditionInfo { get; set; }
    }
}
