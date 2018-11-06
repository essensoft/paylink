using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FaceSearchUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FaceSearchUserInfo : AlipayObject
    {
        /// <summary>
        /// 自定义用户标识
        /// </summary>
        [JsonProperty("customuserid")]
        [XmlElement("customuserid")]
        public string Customuserid { get; set; }

        /// <summary>
        /// 商户标识
        /// </summary>
        [JsonProperty("merchantid")]
        [XmlElement("merchantid")]
        public string Merchantid { get; set; }

        /// <summary>
        /// 商户uid
        /// </summary>
        [JsonProperty("merchantuid")]
        [XmlElement("merchantuid")]
        public string Merchantuid { get; set; }
    }
}
