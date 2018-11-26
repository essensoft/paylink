using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceAirXfgDsgModifyResponse.
    /// </summary>
    public class AlipayCommerceAirXfgDsgModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 用户级别
        /// </summary>
        [JsonProperty("level")]
        [XmlElement("level")]
        public string Level { get; set; }
    }
}
