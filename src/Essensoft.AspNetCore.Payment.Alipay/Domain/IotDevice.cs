using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IotDevice Data Structure.
    /// </summary>
    public class IotDevice : AlipayObject
    {
        /// <summary>
        /// 蓝牙MAC地址
        /// </summary>
        [JsonPropertyName("bluetooth_mac")]
        public string BluetoothMac { get; set; }

        /// <summary>
        /// 设备控制面板地址
        /// </summary>
        [JsonPropertyName("control_url")]
        public string ControlUrl { get; set; }

        /// <summary>
        /// 协议服务商用于唯一标识该设备的设备id(协议服务商定义)
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonPropertyName("device_name")]
        public string DeviceName { get; set; }

        /// <summary>
        /// 协议服务商用于唯一标识一个设备型号的型号id
        /// </summary>
        [JsonPropertyName("model_id")]
        public string ModelId { get; set; }

        /// <summary>
        /// 设备序列号
        /// </summary>
        [JsonPropertyName("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 设备WIFI的MAC地址
        /// </summary>
        [JsonPropertyName("wifi_mac")]
        public string WifiMac { get; set; }
    }
}
