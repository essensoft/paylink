using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringTablecodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringTablecodeQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户在isv界面通过扫一扫传入的url文本
        /// </summary>
        [JsonProperty("url_context")]
        [XmlElement("url_context")]
        public string UrlContext { get; set; }
    }
}
