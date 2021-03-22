using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingConfigQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarParkingConfigQueryModel : AlipayObject
    {
        /// <summary>
        /// 接口名称。H5传入参数固定值：alipay.eco.mycar.parking.userpage.query； 小程序传入参数固定值：alipay.eco.mycar.parking.isv.homepage； 协议状态变更通知传入参数固定值： alipay.eco.mycar.parking.agreement.notify。
        /// </summary>
        [JsonPropertyName("interface_name")]
        public string InterfaceName { get; set; }

        /// <summary>
        /// 接口类型。H5、小程序传入参数固定值：interface_page； 通知接口传入参数固定值：interface_service。
        /// </summary>
        [JsonPropertyName("interface_type")]
        public string InterfaceType { get; set; }
    }
}
