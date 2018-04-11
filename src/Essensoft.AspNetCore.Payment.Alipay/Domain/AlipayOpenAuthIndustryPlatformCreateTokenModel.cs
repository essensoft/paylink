using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAuthIndustryPlatformCreateTokenModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthIndustryPlatformCreateTokenModel : AlipayObject
    {
        /// <summary>
        /// isv的appid
        /// </summary>
        [JsonProperty("isv_appid")]
        [XmlElement("isv_appid")]
        public string IsvAppid { get; set; }

        /// <summary>
        /// auth_mycar_violation
        /// </summary>
        [JsonProperty("scope")]
        [XmlElement("scope")]
        public string Scope { get; set; }
    }
}
