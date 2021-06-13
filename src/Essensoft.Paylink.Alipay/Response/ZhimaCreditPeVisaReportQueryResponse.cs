using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPeVisaReportQueryResponse.
    /// </summary>
    public class ZhimaCreditPeVisaReportQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户签证报告申请状态，枚举字段： 生效中 VALID  已失效 INVALID  不存在 NOT_EXIST
        /// </summary>
        [JsonPropertyName("report_apply_status")]
        public string ReportApplyStatus { get; set; }

        /// <summary>
        /// 签证报告文件内容，仅返回用户申请的最新一份有效报告。需要先base64解码，获取原始byte[]类型文件流。
        /// </summary>
        [JsonPropertyName("report_content_files")]
        public List<string> ReportContentFiles { get; set; }

        /// <summary>
        /// 用户是否准入，当前主要指用户是否满足申请的分数门槛。
        /// </summary>
        [JsonPropertyName("user_permit_status")]
        public bool UserPermitStatus { get; set; }
    }
}
