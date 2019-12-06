using System.Text.Json.Serialization;

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
        [JsonPropertyName("report_condition_info")]
        public CustomReportCondition ReportConditionInfo { get; set; }
    }
}
