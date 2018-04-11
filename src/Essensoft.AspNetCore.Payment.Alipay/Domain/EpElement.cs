using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EpElement Data Structure.
    /// </summary>
    [Serializable]
    public class EpElement : AlipayObject
    {
        /// <summary>
        /// 企业征信数据key
        /// </summary>
        [JsonProperty("key")]
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 企业征信数据value，字段长度不定。
        /// </summary>
        [JsonProperty("value")]
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
