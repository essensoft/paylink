using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityDataAlibabaSecuritydataQueryResponse.
    /// </summary>
    public class AlipaySecurityDataAlibabaSecuritydataQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 风险描述
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 核身校验统计结果,格式为核身校验方式:次数
        /// </summary>
        [JsonPropertyName("identify_result")]
        public string IdentifyResult { get; set; }

        /// <summary>
        /// 用户风险标签，赌博，欺诈，盗用等
        /// </summary>
        [JsonPropertyName("risk_label")]
        public string RiskLabel { get; set; }

        /// <summary>
        /// 风险评分
        /// </summary>
        [JsonPropertyName("risk_score")]
        public string RiskScore { get; set; }
    }
}
