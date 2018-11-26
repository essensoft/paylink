using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FaceSearchAnonymousUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FaceSearchAnonymousUserInfo : AlipayObject
    {
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
