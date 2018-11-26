using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeviceParams Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceParams : AlipayObject
    {
        /// <summary>
        /// 设备Id
        /// </summary>
        [JsonProperty("device_id")]
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonProperty("device_name")]
        [XmlElement("device_name")]
        public string DeviceName { get; set; }

        /// <summary>
        /// 设备类型，目前有四种值：  VR一体机：VR_MACHINE、电视：TV、身份证：ID_CARD、工牌：WORK_CARD
        /// </summary>
        [JsonProperty("device_type")]
        [XmlElement("device_type")]
        public string DeviceType { get; set; }
    }
}
