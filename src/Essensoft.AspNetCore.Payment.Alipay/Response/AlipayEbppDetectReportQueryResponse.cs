using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppDetectReportQueryResponse.
    /// </summary>
    public class AlipayEbppDetectReportQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 注意：该字段废弃。
        /// </summary>
        [JsonPropertyName("audit_done")]
        public bool AuditDone { get; set; }

        /// <summary>
        /// 注意：该字段废弃。
        /// </summary>
        [JsonPropertyName("audit_pass")]
        public bool AuditPass { get; set; }

        /// <summary>
        /// 检测详情报告地址
        /// </summary>
        [JsonPropertyName("detail_report")]
        public string DetailReport { get; set; }

        /// <summary>
        /// 检测结果详情。JSON数组字符串。列出每个检测项的检测详情。
        /// </summary>
        [JsonPropertyName("detect_detail")]
        public string DetectDetail { get; set; }

        /// <summary>
        /// 检测结果详情，案例过长，可查看 https://yuque.antfin-inc.com/docs/share/dc6d16d3-08c1-46d2-a1ed-c0ca6bbba07d?# 或联系 @温酒 @赵旭敏
        /// </summary>
        [JsonPropertyName("detect_result")]
        public string DetectResult { get; set; }

        /// <summary>
        /// 检测状态.  * 0-未查到报告(检测未开始或检测异常)  * 1-检测中  * 2-检测结束并生成检测报告
        /// </summary>
        [JsonPropertyName("detect_status")]
        public long DetectStatus { get; set; }

        /// <summary>
        /// 注意：该字段废弃
        /// </summary>
        [JsonPropertyName("err_msg")]
        public string ErrMsg { get; set; }

        /// <summary>
        /// 注意：该字段废弃。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 整体检测是否通过. 只有当detectStatus=2时才会有值.  * true-检测通过  * false-检测不通过
        /// </summary>
        [JsonPropertyName("pass")]
        public bool Pass { get; set; }

        /// <summary>
        /// 检测结果一句话描述
        /// </summary>
        [JsonPropertyName("summary")]
        public string Summary { get; set; }
    }
}
