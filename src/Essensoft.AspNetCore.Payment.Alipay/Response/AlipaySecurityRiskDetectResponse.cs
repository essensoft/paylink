using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityRiskDetectResponse.
    /// </summary>
    public class AlipaySecurityRiskDetectResponse : AlipayResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("risk_code")]
        public string RiskCode { get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [JsonPropertyName("risk_level")]
        public long RiskLevel { get; set; }
    }
}
