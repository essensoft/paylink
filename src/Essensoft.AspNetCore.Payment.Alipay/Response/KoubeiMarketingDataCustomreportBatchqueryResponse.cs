using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingDataCustomreportBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 分页输出自定义开放数据规则列表
        /// </summary>
        [JsonPropertyName("report_condition_list")]
        public List<CustomReportCondition> ReportConditionList { get; set; }
    }
}
