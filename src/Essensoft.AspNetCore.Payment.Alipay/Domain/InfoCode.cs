using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InfoCode Data Structure.
    /// </summary>
    [Serializable]
    public class InfoCode : AlipayObject
    {
        /// <summary>
        /// 风险描述
        /// </summary>
        [JsonProperty("risk_description")]
        [XmlElement("risk_description")]
        public string RiskDescription { get; set; }

        /// <summary>
        /// 风险因素编码
        /// </summary>
        [JsonProperty("risk_factor_code")]
        [XmlElement("risk_factor_code")]
        public string RiskFactorCode { get; set; }

        /// <summary>
        /// 风险因素名称
        /// </summary>
        [JsonProperty("risk_factor_name")]
        [XmlElement("risk_factor_name")]
        public string RiskFactorName { get; set; }

        /// <summary>
        /// 风险度量，子特征风险分，范围 0-10，值越大表示风险越高
        /// </summary>
        [JsonProperty("risk_magnitude")]
        [XmlElement("risk_magnitude")]
        public string RiskMagnitude { get; set; }
    }
}
