using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RiskRankInfoCode Data Structure.
    /// </summary>
    [Serializable]
    public class RiskRankInfoCode : AlipayObject
    {
        /// <summary>
        /// infocode
        /// </summary>
        [JsonProperty("code")]
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 此infocode在总的得分中的贡献度
        /// </summary>
        [JsonProperty("contribution_degree")]
        [XmlElement("contribution_degree")]
        public long ContributionDegree { get; set; }

        /// <summary>
        /// 风险描述
        /// </summary>
        [JsonProperty("desc")]
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 模型名称
        /// </summary>
        [JsonProperty("model_name")]
        [XmlElement("model_name")]
        public string ModelName { get; set; }
    }
}
