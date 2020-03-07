using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeviceSyncPayload Data Structure.
    /// </summary>
    public class DeviceSyncPayload : AlipayObject
    {
        /// <summary>
        /// 触发行为:绑定、解绑、变更等
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 智能设备唯一ID
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }
    }
}
