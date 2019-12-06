using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// HoloGraphicContactInfo Data Structure.
    /// </summary>
    public class HoloGraphicContactInfo : AlipayObject
    {
        /// <summary>
        /// 主叫通话频次
        /// </summary>
        [JsonPropertyName("call_frequency")]
        public long CallFrequency { get; set; }

        /// <summary>
        /// 主叫通话时长
        /// </summary>
        [JsonPropertyName("call_time")]
        public long CallTime { get; set; }

        /// <summary>
        /// 被叫通话频次
        /// </summary>
        [JsonPropertyName("called_frequency")]
        public long CalledFrequency { get; set; }

        /// <summary>
        /// 被叫通话时长
        /// </summary>
        [JsonPropertyName("called_time")]
        public long CalledTime { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 通话频次
        /// </summary>
        [JsonPropertyName("talk_frequency")]
        public long TalkFrequency { get; set; }

        /// <summary>
        /// 通话时长
        /// </summary>
        [JsonPropertyName("talk_time")]
        public long TalkTime { get; set; }
    }
}
