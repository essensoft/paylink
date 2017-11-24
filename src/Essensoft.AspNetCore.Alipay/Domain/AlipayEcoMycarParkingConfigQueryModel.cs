using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingConfigQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarParkingConfigQueryModel : AlipayObject
    {
        /// <summary>
        /// 传入参数固定值:alipay.eco.mycar.parking.userpage.query
        /// </summary>
        [JsonProperty("interface_name")]
        public string InterfaceName { get; set; }

        /// <summary>
        /// 传入参数固定值:interface_page
        /// </summary>
        [JsonProperty("interface_type")]
        public string InterfaceType { get; set; }
    }
}
