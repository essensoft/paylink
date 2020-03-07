using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeviceBehaviorLogResponse Data Structure.
    /// </summary>
    public class DeviceBehaviorLogResponse : AlipayObject
    {
        /// <summary>
        /// 行为日志类型，SCAN_CDOE:扫码/HEARTBEAT:心跳
        /// </summary>
        [JsonPropertyName("behavior_type")]
        public string BehaviorType { get; set; }

        /// <summary>
        /// 日志对应的设备信息
        /// </summary>
        [JsonPropertyName("log_content")]
        public string LogContent { get; set; }

        /// <summary>
        /// 日志时间
        /// </summary>
        [JsonPropertyName("log_time")]
        public string LogTime { get; set; }
    }
}
