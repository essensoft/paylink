using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IotDevice Data Structure.
    /// </summary>
    [Serializable]
    public class IotDevice : AlipayObject
    {
        /// <summary>
        /// 蓝牙MAC地址
        /// </summary>
        [JsonProperty("bluetooth_mac")]
        [XmlElement("bluetooth_mac")]
        public string BluetoothMac { get; set; }

        /// <summary>
        /// 设备控制面板地址
        /// </summary>
        [JsonProperty("control_url")]
        [XmlElement("control_url")]
        public string ControlUrl { get; set; }

        /// <summary>
        /// 协议服务商用于唯一标识该设备的设备id(协议服务商定义)
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
        /// 协议服务商用于唯一标识一个设备型号的型号id
        /// </summary>
        [JsonProperty("model_id")]
        [XmlElement("model_id")]
        public string ModelId { get; set; }

        /// <summary>
        /// 设备序列号
        /// </summary>
        [JsonProperty("sn")]
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 设备WIFI的MAC地址
        /// </summary>
        [JsonProperty("wifi_mac")]
        [XmlElement("wifi_mac")]
        public string WifiMac { get; set; }
    }
}
