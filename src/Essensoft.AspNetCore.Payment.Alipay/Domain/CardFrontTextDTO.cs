using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CardFrontTextDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CardFrontTextDTO : AlipayObject
    {
        /// <summary>
        /// 文案标签
        /// </summary>
        [JsonProperty("label")]
        [XmlElement("label")]
        public string Label { get; set; }

        /// <summary>
        /// 展示文案
        /// </summary>
        [JsonProperty("value")]
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
