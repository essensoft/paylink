using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StatesSyncPayload Data Structure.
    /// </summary>
    public class StatesSyncPayload : AlipayObject
    {
        /// <summary>
        /// 智能设备唯一ID
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 是否在线
        /// </summary>
        [JsonPropertyName("online")]
        public bool Online { get; set; }

        /// <summary>
        /// 状态信息Json串
        /// </summary>
        [JsonPropertyName("states")]
        public string States { get; set; }
    }
}
