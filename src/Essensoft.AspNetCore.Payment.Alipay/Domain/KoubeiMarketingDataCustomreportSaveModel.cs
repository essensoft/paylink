using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportSaveModel Data Structure.
    /// </summary>
    public class KoubeiMarketingDataCustomreportSaveModel : AlipayObject
    {
        /// <summary>
        /// 自定义报表规则条件信息
        /// </summary>
        [JsonProperty("report_condition_info")]
        public CustomReportCondition ReportConditionInfo { get; set; }
    }
}
