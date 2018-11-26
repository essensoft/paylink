using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingVehicleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingVehicleQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝用户车辆ID，系统唯一。（该参数会在停车平台用户点击查询缴费，跳转到ISV停车缴费查询页面时，从请求中传递）
        /// </summary>
        [JsonProperty("car_id")]
        [XmlElement("car_id")]
        public string CarId { get; set; }
    }
}
