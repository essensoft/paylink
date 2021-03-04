using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportDetailQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataCustomreportDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 自定义报表规则条件的详细信息
        /// </summary>
        [JsonPropertyName("report_condition_info")]
        public CustomReportCondition ReportConditionInfo { get; set; }
    }
}
