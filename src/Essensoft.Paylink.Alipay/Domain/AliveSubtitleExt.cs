using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AliveSubtitleExt Data Structure.
    /// </summary>
    public class AliveSubtitleExt : AlipayObject
    {
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
