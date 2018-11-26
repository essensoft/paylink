using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertAdvContent Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertAdvContent : AlipayObject
    {
        /// <summary>
        /// 二维码
        /// </summary>
        [JsonProperty("codec")]
        [XmlElement("codec")]
        public string Codec { get; set; }

        /// <summary>
        /// 访问地址
        /// </summary>
        [JsonProperty("link_url")]
        [XmlElement("link_url")]
        public string LinkUrl { get; set; }
    }
}
