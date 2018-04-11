using Newtonsoft.Json;
using System.Xml.Serialization;

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
        [JsonProperty("risk_code")]
        [XmlElement("risk_code")]
        public string RiskCode { get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [JsonProperty("risk_level")]
        [XmlElement("risk_level")]
        public long RiskLevel { get; set; }
    }
}
