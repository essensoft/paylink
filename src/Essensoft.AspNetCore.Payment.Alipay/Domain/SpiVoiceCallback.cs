using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SpiVoiceCallback Data Structure.
    /// </summary>
    public class SpiVoiceCallback : AlipayObject
    {
        /// <summary>
        /// 阿里云语音编号
        /// </summary>
        [JsonPropertyName("call_id")]
        public string CallId { get; set; }

        /// <summary>
        /// 被叫电话
        /// </summary>
        [JsonPropertyName("callee")]
        public string Callee { get; set; }

        /// <summary>
        /// 通话时间
        /// </summary>
        [JsonPropertyName("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 通话结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 数立内部业务编号
        /// </summary>
        [JsonPropertyName("out_id")]
        public string OutId { get; set; }

        /// <summary>
        /// 通话开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 语音状态：200000-用户听完语音;200001-用户提前挂机未完整收听;200002-用户占线
        /// </summary>
        [JsonPropertyName("status_code")]
        public string StatusCode { get; set; }
    }
}
