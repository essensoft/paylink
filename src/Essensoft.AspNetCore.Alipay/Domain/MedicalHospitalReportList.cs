using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// MedicalHospitalReportList Data Structure.
    /// </summary>
    public class MedicalHospitalReportList : AlipayObject
    {
        /// <summary>
        /// 报告产出日期 格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonProperty("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 报告说明
        /// </summary>
        [JsonProperty("report_desc")]
        public string ReportDesc { get; set; }

        /// <summary>
        /// 报告详情连接
        /// </summary>
        [JsonProperty("report_link")]
        public string ReportLink { get; set; }

        /// <summary>
        /// 报告名称
        /// </summary>
        [JsonProperty("report_name")]
        public string ReportName { get; set; }

        /// <summary>
        /// 报告类型:  CHECK_REPORT 检查报告  EXAM_REPORT检验报告
        /// </summary>
        [JsonProperty("report_type")]
        public string ReportType { get; set; }
    }
}
