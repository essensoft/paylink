using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DevicePushPayload Data Structure.
    /// </summary>
    public class DevicePushPayload : AlipayObject
    {
        /// <summary>
        /// 设备唯一ID
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 消息通知数据模型
        /// </summary>
        [JsonPropertyName("notify_params")]
        public string NotifyParams { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }
    }
}
