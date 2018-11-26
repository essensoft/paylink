using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieSpaceDomains Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieSpaceDomains : AlipayObject
    {
        /// <summary>
        /// 发布的域名，在云凤蝶上创建的站点发布时采用的 url 域名
        /// </summary>
        [JsonProperty("domain")]
        [XmlElement("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// 是否是当前云凤蝶空间的默认发布域名，Y 则表示该空间下的站点默认以此域名生成站点url
        /// </summary>
        [JsonProperty("is_default")]
        [XmlElement("is_default")]
        public string IsDefault { get; set; }

        /// <summary>
        /// 当前域名状态，是否可用，值为 OPEN 或 DISCARDED
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
