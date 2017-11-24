using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// InfoCode Data Structure.
    /// </summary>
    public class InfoCode : AlipayObject
    {
        /// <summary>
        /// 风险描述
        /// </summary>
        [JsonProperty("risk_description")]
        public string RiskDescription { get; set; }

        /// <summary>
        /// 风险因素编码
        /// </summary>
        [JsonProperty("risk_factor_code")]
        public string RiskFactorCode { get; set; }

        /// <summary>
        /// 风险因素名称
        /// </summary>
        [JsonProperty("risk_factor_name")]
        public string RiskFactorName { get; set; }

        /// <summary>
        /// 风险度量
        /// </summary>
        [JsonProperty("risk_magnitude")]
        public string RiskMagnitude { get; set; }
    }
}
