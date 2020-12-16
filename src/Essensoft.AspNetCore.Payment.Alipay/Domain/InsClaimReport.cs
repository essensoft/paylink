using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsClaimReport Data Structure.
    /// </summary>
    public class InsClaimReport : AlipayObject
    {
        /// <summary>
        /// 出险地点
        /// </summary>
        [JsonPropertyName("accident_address")]
        public string AccidentAddress { get; set; }

        /// <summary>
        /// 出险事故描述
        /// </summary>
        [JsonPropertyName("accident_desc")]
        public string AccidentDesc { get; set; }

        /// <summary>
        /// 出险时间
        /// </summary>
        [JsonPropertyName("accident_time")]
        public string AccidentTime { get; set; }

        /// <summary>
        /// 案件附件列表
        /// </summary>
        [JsonPropertyName("attachments")]
        public List<InsClaimAttachment> Attachments { get; set; }

        /// <summary>
        /// 业务字段
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 报案号
        /// </summary>
        [JsonPropertyName("claim_report_no")]
        public string ClaimReportNo { get; set; }

        /// <summary>
        /// 报案类型
        /// </summary>
        [JsonPropertyName("claim_report_type")]
        public string ClaimReportType { get; set; }

        /// <summary>
        /// 赔案信息
        /// </summary>
        [JsonPropertyName("claims")]
        public List<InsClaim> Claims { get; set; }

        /// <summary>
        /// 案件进度列表
        /// </summary>
        [JsonPropertyName("progress")]
        public List<InsClaimReportProgress> Progress { get; set; }

        /// <summary>
        /// 当status 值为不予受理:REJECTED时候返回
        /// </summary>
        [JsonPropertyName("report_reject_reason")]
        public string ReportRejectReason { get; set; }

        /// <summary>
        /// 报案人
        /// </summary>
        [JsonPropertyName("reporter")]
        public InsPerson Reporter { get; set; }

        /// <summary>
        /// 报案来源
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 案件状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
