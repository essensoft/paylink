using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneClaimReportModifyModel Data Structure.
    /// </summary>
    public class AlipayInsSceneClaimReportModifyModel : AlipayObject
    {
        /// <summary>
        /// 出险地点
        /// </summary>
        [JsonPropertyName("accident_address")]
        public string AccidentAddress { get; set; }

        /// <summary>
        /// 出险描述
        /// </summary>
        [JsonPropertyName("accident_desc")]
        public string AccidentDesc { get; set; }

        /// <summary>
        /// 出险时间
        /// </summary>
        [JsonPropertyName("accident_time")]
        public string AccidentTime { get; set; }

        /// <summary>
        /// 理赔报案的属性字段，标准JSON格式
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 申请理赔的报案号
        /// </summary>
        [JsonPropertyName("claim_report_no")]
        public string ClaimReportNo { get; set; }
    }
}
