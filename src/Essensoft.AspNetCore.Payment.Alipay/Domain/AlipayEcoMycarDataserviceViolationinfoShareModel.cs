using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarDataserviceViolationinfoShareModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarDataserviceViolationinfoShareModel : AlipayObject
    {
        /// <summary>
        /// 支付宝app_id
        /// </summary>
        [JsonProperty("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 车辆id
        /// </summary>
        [JsonProperty("vehicle_id")]
        public string VehicleId { get; set; }
    }
}
