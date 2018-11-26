using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PublicLabel Data Structure.
    /// </summary>
    [Serializable]
    public class PublicLabel : AlipayObject
    {
        /// <summary>
        /// 标签用户量
        /// </summary>
        [JsonProperty("count")]
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 标签编号
        /// </summary>
        [JsonProperty("id")]
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
