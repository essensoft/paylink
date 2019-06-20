using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeviceBehaviorLogResponse Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceBehaviorLogResponse : AlipayObject
    {
        /// <summary>
        /// 行为日志类型，SCAN_CDOE:扫码/HEARTBEAT:心跳
        /// </summary>
        [JsonProperty("behavior_type")]
        public string BehaviorType { get; set; }

        /// <summary>
        /// 日志对应的设备信息
        /// </summary>
        [JsonProperty("log_content")]
        public string LogContent { get; set; }

        /// <summary>
        /// 日志时间
        /// </summary>
        [JsonProperty("log_time")]
        public string LogTime { get; set; }
    }
}
