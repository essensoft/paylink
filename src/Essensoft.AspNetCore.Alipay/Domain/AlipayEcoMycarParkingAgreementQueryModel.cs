using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingAgreementQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarParkingAgreementQueryModel : AlipayObject
    {
        /// <summary>
        /// 车牌，用户车辆进场时ISV设备识别到的车辆牌照
        /// </summary>
        [JsonProperty("car_number")]
        public string CarNumber { get; set; }
    }
}
