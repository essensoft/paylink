using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityInfoAnalysisResponse.
    /// </summary>
    public class AlipaySecurityInfoAnalysisResponse : AlipayResponse
    {
        /// <summary>
        /// 风险标签
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
