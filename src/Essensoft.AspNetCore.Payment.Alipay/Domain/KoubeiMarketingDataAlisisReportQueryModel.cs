using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataAlisisReportQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingDataAlisisReportQueryModel : AlipayObject
    {
        /// <summary>
        /// 报表查询过滤条件
        /// </summary>
        [JsonPropertyName("conditions")]
        public List<ReportQueryCondition> Conditions { get; set; }

        /// <summary>
        /// 报表唯一标识
        /// </summary>
        [JsonPropertyName("report_uk")]
        public string ReportUk { get; set; }
    }
}
