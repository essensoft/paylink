using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AmpeDeviceTypeInfo Data Structure.
    /// </summary>
    public class AmpeDeviceTypeInfo : AlipayObject
    {
        /// <summary>
        /// 设备类型
        /// </summary>
        [JsonPropertyName("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 设备类描述
        /// </summary>
        [JsonPropertyName("device_type_desc")]
        public string DeviceTypeDesc { get; set; }
    }
}
