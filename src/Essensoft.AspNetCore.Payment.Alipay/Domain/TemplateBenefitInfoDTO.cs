using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateBenefitInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateBenefitInfoDTO : AlipayObject
    {
        /// <summary>
        /// 权益描述信息
        /// </summary>
        [JsonProperty("benefit_desc")]
        [XmlArray("benefit_desc")]
        [XmlArrayItem("string")]
        public List<string> BenefitDesc { get; set; }

        /// <summary>
        /// 权益结束时间
        /// </summary>
        [JsonProperty("end_date")]
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("start_date")]
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 权益描述
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
