using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AppVisitTrendDataResponse Data Structure.
    /// </summary>
    public class AppVisitTrendDataResponse : AlipayObject
    {
        /// <summary>
        /// 小程序的访问次数
        /// </summary>
        [JsonPropertyName("app_pv")]
        public long AppPv { get; set; }

        /// <summary>
        /// 小程序访问人数
        /// </summary>
        [JsonPropertyName("app_uv")]
        public long AppUv { get; set; }

        /// <summary>
        /// 数据采集时间 yyyy-MM-dd hh:mm:ss
        /// </summary>
        [JsonPropertyName("report_time")]
        public string ReportTime { get; set; }
    }
}
