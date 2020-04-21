using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityRiskReconfirmRiskidentifyCertifyResponse.
    /// </summary>
    public class AlipaySecurityRiskReconfirmRiskidentifyCertifyResponse : AlipayResponse
    {
        /// <summary>
        /// 额外信息
        /// </summary>
        [JsonPropertyName("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 是否有风险  该字段为风险检测结果，不敏感，无需脱敏
        /// </summary>
        [JsonPropertyName("has_risk")]
        public bool HasRisk { get; set; }

        /// <summary>
        /// 风险识别id，为一个标识id，不敏感，无需脱敏
        /// </summary>
        [JsonPropertyName("identify_id")]
        public string IdentifyId { get; set; }
    }
}
