using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// DeviceServiceVO Data Structure.
    /// </summary>
    public class DeviceServiceVO : AlipayObject
    {
        /// <summary>
        /// 拥有服务的设备基础信息
        /// </summary>
        [JsonPropertyName("device_service_base")]
        public DeviceServiceBaseVO DeviceServiceBase { get; set; }

        /// <summary>
        /// 如果拥有服务的设备为间联子设备，则这里会带上网关设备信息
        /// </summary>
        [JsonPropertyName("parent_base")]
        public DeviceServiceBaseVO ParentBase { get; set; }

        /// <summary>
        /// 服务模型key
        /// </summary>
        [JsonPropertyName("service_key")]
        public string ServiceKey { get; set; }

        /// <summary>
        /// 服务模型内部版本号
        /// </summary>
        [JsonPropertyName("version_no")]
        public long VersionNo { get; set; }
    }
}
