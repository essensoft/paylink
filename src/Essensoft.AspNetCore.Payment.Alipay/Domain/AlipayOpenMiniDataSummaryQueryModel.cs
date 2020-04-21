using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniDataSummaryQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniDataSummaryQueryModel : AlipayObject
    {
        /// <summary>
        /// 请求数据的日期
        /// </summary>
        [JsonPropertyName("report_date")]
        public string ReportDate { get; set; }
    }
}
