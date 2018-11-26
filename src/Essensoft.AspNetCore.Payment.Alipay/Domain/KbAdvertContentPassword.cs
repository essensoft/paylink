using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertContentPassword Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertContentPassword : AlipayObject
    {
        /// <summary>
        /// 红包口令
        /// </summary>
        [JsonProperty("password")]
        [XmlElement("password")]
        public string Password { get; set; }

        /// <summary>
        /// 红包口令分享地址
        /// </summary>
        [JsonProperty("share_page_url")]
        [XmlElement("share_page_url")]
        public string SharePageUrl { get; set; }
    }
}
