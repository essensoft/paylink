using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicPartnerMenuQueryResponse.
    /// </summary>
    public class AlipayOpenPublicPartnerMenuQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 服务窗菜单
        /// </summary>
        [JsonProperty("public_menu")]
        [XmlElement("public_menu")]
        public string PublicMenu { get; set; }
    }
}
