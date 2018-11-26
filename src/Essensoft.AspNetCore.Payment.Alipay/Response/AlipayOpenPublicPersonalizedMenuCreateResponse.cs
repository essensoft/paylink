using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicPersonalizedMenuCreateResponse.
    /// </summary>
    public class AlipayOpenPublicPersonalizedMenuCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 该套个性化菜单key
        /// </summary>
        [JsonProperty("menu_key")]
        [XmlElement("menu_key")]
        public string MenuKey { get; set; }
    }
}
