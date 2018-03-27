using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IotDevicePersonalInfo Data Structure.
    /// </summary>
    public class IotDevicePersonalInfo : AlipayObject
    {
        /// <summary>
        /// 协议服务商用于唯一标识该设备的设备id(协议服务商定义)
        /// </summary>
        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备备注
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }
    }
}
