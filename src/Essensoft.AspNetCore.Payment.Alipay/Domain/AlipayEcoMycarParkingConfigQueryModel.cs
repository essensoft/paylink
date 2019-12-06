using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingConfigQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarParkingConfigQueryModel : AlipayObject
    {
        /// <summary>
        /// H5传入参数固定值：alipay.eco.mycar.parking.userpage.query    小程序传入参数固定值：alipay.eco.mycar.parking.isv.homepage
        /// </summary>
        [JsonPropertyName("interface_name")]
        public string InterfaceName { get; set; }

        /// <summary>
        /// 传入参数固定值:interface_page
        /// </summary>
        [JsonPropertyName("interface_type")]
        public string InterfaceType { get; set; }
    }
}
