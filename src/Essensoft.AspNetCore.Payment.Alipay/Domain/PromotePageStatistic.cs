using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PromotePageStatistic Data Structure.
    /// </summary>
    public class PromotePageStatistic : AlipayObject
    {
        /// <summary>
        /// 留资量
        /// </summary>
        [JsonPropertyName("conversion_cnt")]
        public string ConversionCnt { get; set; }

        /// <summary>
        /// 留资页页面ID
        /// </summary>
        [JsonPropertyName("page_id")]
        public string PageId { get; set; }

        /// <summary>
        /// 留资页名称
        /// </summary>
        [JsonPropertyName("page_name")]
        public string PageName { get; set; }

        /// <summary>
        /// 页面浏览pv
        /// </summary>
        [JsonPropertyName("pv")]
        public string Pv { get; set; }

        /// <summary>
        /// 格式YYYYMMdd
        /// </summary>
        [JsonPropertyName("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 人均停留时长(秒)
        /// </summary>
        [JsonPropertyName("residence_time")]
        public string ResidenceTime { get; set; }

        /// <summary>
        /// 页面浏览uv
        /// </summary>
        [JsonPropertyName("uv")]
        public string Uv { get; set; }
    }
}
