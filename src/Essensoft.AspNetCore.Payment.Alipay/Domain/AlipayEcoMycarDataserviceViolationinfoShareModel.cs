using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarDataserviceViolationinfoShareModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarDataserviceViolationinfoShareModel : AlipayObject
    {
        /// <summary>
        /// 支付宝app_id
        /// </summary>
        [JsonProperty("app_id")]
        [XmlElement("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 车辆id
        /// </summary>
        [JsonProperty("vehicle_id")]
        [XmlElement("vehicle_id")]
        public string VehicleId { get; set; }
    }
}
