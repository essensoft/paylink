using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsMktFactorDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsMktFactorDTO : AlipayObject
    {
        /// <summary>
        /// 规则因子
        /// </summary>
        [JsonProperty("key")]
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 规则因子值
        /// </summary>
        [JsonProperty("value")]
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
