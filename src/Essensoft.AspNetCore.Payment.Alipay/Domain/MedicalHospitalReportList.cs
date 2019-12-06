using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MedicalHospitalReportList Data Structure.
    /// </summary>
    public class MedicalHospitalReportList : AlipayObject
    {
        /// <summary>
        /// 报告产出日期 格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonPropertyName("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 报告说明
        /// </summary>
        [JsonPropertyName("report_desc")]
        public string ReportDesc { get; set; }

        /// <summary>
        /// 报告详情连接
        /// </summary>
        [JsonPropertyName("report_link")]
        public string ReportLink { get; set; }

        /// <summary>
        /// 报告名称
        /// </summary>
        [JsonPropertyName("report_name")]
        public string ReportName { get; set; }

        /// <summary>
        /// 报告类型:  CHECK_REPORT 检查报告  EXAM_REPORT检验报告
        /// </summary>
        [JsonPropertyName("report_type")]
        public string ReportType { get; set; }
    }
}
