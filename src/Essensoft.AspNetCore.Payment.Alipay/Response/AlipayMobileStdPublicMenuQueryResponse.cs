using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobileStdPublicMenuQueryResponse.
    /// </summary>
    public class AlipayMobileStdPublicMenuQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 所有菜单列表json串
        /// </summary>
        [JsonProperty("all_menu_list")]
        [XmlElement("all_menu_list")]
        public string AllMenuList { get; set; }
    }
}
