using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AudioEvent Data Structure.
    /// </summary>
    public class AudioEvent : AlipayObject
    {
        /// <summary>
        /// 语音id, 也就是语音合成接口返回的audio_id
        /// </summary>
        [JsonPropertyName("audio_id")]
        public string AudioId { get; set; }

        /// <summary>
        /// 播报语音的结束时间,标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 播报语音的开始时间,标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}
