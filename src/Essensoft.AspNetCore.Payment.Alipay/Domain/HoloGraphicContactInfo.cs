using Newtonsoft.Json;

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
        [JsonProperty("call_frequency")]
        public long CallFrequency { get; set; }

        /// <summary>
        /// 主叫通话时长
        /// </summary>
        [JsonProperty("call_time")]
        public long CallTime { get; set; }

        /// <summary>
        /// 被叫通话频次
        /// </summary>
        [JsonProperty("called_frequency")]
        public long CalledFrequency { get; set; }

        /// <summary>
        /// 被叫通话时长
        /// </summary>
        [JsonProperty("called_time")]
        public long CalledTime { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 通话频次
        /// </summary>
        [JsonProperty("talk_frequency")]
        public long TalkFrequency { get; set; }

        /// <summary>
        /// 通话时长
        /// </summary>
        [JsonProperty("talk_time")]
        public long TalkTime { get; set; }
    }
}
