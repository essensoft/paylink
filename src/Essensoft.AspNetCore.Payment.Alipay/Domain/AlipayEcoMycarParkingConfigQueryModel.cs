using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingConfigQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingConfigQueryModel : AlipayObject
    {
        /// <summary>
        /// 传入参数固定值:alipay.eco.mycar.parking.userpage.query
        /// </summary>
        [JsonProperty("interface_name")]
        [XmlElement("interface_name")]
        public string InterfaceName { get; set; }

        /// <summary>
        /// 传入参数固定值:interface_page
        /// </summary>
        [JsonProperty("interface_type")]
        [XmlElement("interface_type")]
        public string InterfaceType { get; set; }
    }
}
