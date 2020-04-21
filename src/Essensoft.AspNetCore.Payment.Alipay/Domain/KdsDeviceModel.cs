using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KdsDeviceModel Data Structure.
    /// </summary>
    public class KdsDeviceModel : AlipayObject
    {
        /// <summary>
        /// 设备编号
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 设备sn号
        /// </summary>
        [JsonPropertyName("sn_id")]
        public string SnId { get; set; }
    }
}
