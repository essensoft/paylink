using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AliveSubtitleExt Data Structure.
    /// </summary>
    public class AliveSubtitleExt : AlipayObject
    {
        /// <summary>
        /// 字幕命中特殊行为逻辑，例如口播关注
        /// </summary>
        [JsonPropertyName("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// base64 url
        /// </summary>
        [JsonPropertyName("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 当前句子识别结果的置信度，取值范围：[0.0,1.0]。值越大表示置信度越高
        /// </summary>
        [JsonPropertyName("confidence")]
        public string Confidence { get; set; }

        /// <summary>
        /// 句子截止时间，单位为ms
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 句子编号，从1开始递增（asr规则）。
        /// </summary>
        [JsonPropertyName("index")]
        public long Index { get; set; }

        /// <summary>
        /// PASSED("数据识别通过，可以在网站上正常显示"),      REJECTED("被拒绝的数据，比如内容出现违禁词；不能出现在我们网站上"),      REJECTED_CC("被拒绝的数据，但是展示效果为CC效果"),      CC("CC表示用户发表数据后，提示成功。"),      RECOVER("恢复数据，将误判断的内容，恢复回来"),      DELETE("删除数据, 为了不扩大化数据的传播，删除历史已经发出去的数据。");
        /// </summary>
        [JsonPropertyName("info_sec_result")]
        public string InfoSecResult { get; set; }

        /// <summary>
        /// 句子超始时间，单位为ms
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 长句拆为短句后，长句中索引，从0开始
        /// </summary>
        [JsonPropertyName("sub_index")]
        public long SubIndex { get; set; }
    }
}
