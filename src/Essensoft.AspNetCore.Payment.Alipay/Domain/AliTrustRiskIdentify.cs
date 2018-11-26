using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AliTrustRiskIdentify Data Structure.
    /// </summary>
    [Serializable]
    public class AliTrustRiskIdentify : AlipayObject
    {
        /// <summary>
        /// 芝麻信用风险名单详情列表
        /// </summary>
        [JsonProperty("details")]
        [XmlArray("details")]
        [XmlArrayItem("zhima_risk_detail")]
        public List<ZhimaRiskDetail> Details { get; set; }

        /// <summary>
        /// 当有风险时,为"T";无风险识别是为"F"
        /// </summary>
        [JsonProperty("is_risk")]
        [XmlElement("is_risk")]
        public string IsRisk { get; set; }

        /// <summary>
        /// 已废弃
        /// </summary>
        [JsonProperty("risk_tag")]
        [XmlElement("risk_tag")]
        public string RiskTag { get; set; }
    }
}
