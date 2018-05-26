using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppXwbsssQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppXwbsssQueryModel : AlipayObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("a")]
        [XmlElement("a")]
        public string A { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("b")]
        [XmlElement("b")]
        public string B { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("c")]
        [XmlArray("c")]
        [XmlArrayItem("number")]
        public List<long> C { get; set; }

        /// <summary>
        /// 描述描述描述描述
        /// </summary>
        [JsonProperty("effect_date")]
        [XmlElement("effect_date")]
        public string EffectDate { get; set; }
    }
}
