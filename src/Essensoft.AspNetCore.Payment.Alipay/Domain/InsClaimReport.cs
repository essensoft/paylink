using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsClaimReport Data Structure.
    /// </summary>
    [Serializable]
    public class InsClaimReport : AlipayObject
    {
        /// <summary>
        /// 出险地点
        /// </summary>
        [JsonProperty("accident_address")]
        public string AccidentAddress { get; set; }

        /// <summary>
        /// 出险事故描述
        /// </summary>
        [JsonProperty("accident_desc")]
        public string AccidentDesc { get; set; }

        /// <summary>
        /// 出险时间
        /// </summary>
        [JsonProperty("accident_time")]
        public string AccidentTime { get; set; }

        /// <summary>
        /// 案件附件列表
        /// </summary>
        [JsonProperty("attachments")]
        public List<InsClaimAttachment> Attachments { get; set; }

        /// <summary>
        /// 业务字段
        /// </summary>
        [JsonProperty("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 报案号
        /// </summary>
        [JsonProperty("claim_report_no")]
        public string ClaimReportNo { get; set; }

        /// <summary>
        /// 赔案信息
        /// </summary>
        [JsonProperty("claims")]
        public List<InsClaim> Claims { get; set; }

        /// <summary>
        /// 案件进度列表
        /// </summary>
        [JsonProperty("progress")]
        public List<InsClaimReportProgress> Progress { get; set; }

        /// <summary>
        /// 当status 值为不予受理:REJECTED时候返回
        /// </summary>
        [JsonProperty("report_reject_reason")]
        public string ReportRejectReason { get; set; }

        /// <summary>
        /// 报案人
        /// </summary>
        [JsonProperty("reporter")]
        public InsPerson Reporter { get; set; }

        /// <summary>
        /// 案件状态
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
