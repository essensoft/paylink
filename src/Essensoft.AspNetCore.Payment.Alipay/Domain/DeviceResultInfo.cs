using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeviceResultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceResultInfo : AlipayObject
    {
        /// <summary>
        /// 设备id
        /// </summary>
        [JsonProperty("device_id")]
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 业务数据类型
        /// </summary>
        [JsonProperty("device_label")]
        [XmlElement("device_label")]
        public string DeviceLabel { get; set; }
    }
}
