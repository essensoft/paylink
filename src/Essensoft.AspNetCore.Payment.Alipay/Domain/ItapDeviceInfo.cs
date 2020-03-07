using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItapDeviceInfo Data Structure.
    /// </summary>
    public class ItapDeviceInfo : AlipayObject
    {
        /// <summary>
        /// 固件版本
        /// </summary>
        [JsonPropertyName("fw_version")]
        public string FwVersion { get; set; }

        /// <summary>
        /// 硬件版本
        /// </summary>
        [JsonPropertyName("hw_version")]
        public string HwVersion { get; set; }

        /// <summary>
        /// 设备厂商名字
        /// </summary>
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }

        /// <summary>
        /// 产品型号
        /// </summary>
        [JsonPropertyName("model")]
        public string Model { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonPropertyName("product_name")]
        public string ProductName { get; set; }
    }
}
