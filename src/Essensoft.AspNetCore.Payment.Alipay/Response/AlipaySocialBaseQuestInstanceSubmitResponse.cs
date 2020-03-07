using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialBaseQuestInstanceSubmitResponse.
    /// </summary>
    public class AlipaySocialBaseQuestInstanceSubmitResponse : AlipayResponse
    {
        /// <summary>
        /// 今日打卡次数
        /// </summary>
        [JsonPropertyName("daily_count")]
        public long DailyCount { get; set; }

        /// <summary>
        /// 打卡总天数
        /// </summary>
        [JsonPropertyName("mark_amount")]
        public long MarkAmount { get; set; }

        /// <summary>
        /// 打卡时间戳
        /// </summary>
        [JsonPropertyName("mark_time")]
        public long MarkTime { get; set; }

        /// <summary>
        /// 打卡成功文案
        /// </summary>
        [JsonPropertyName("mark_tip")]
        public string MarkTip { get; set; }
    }
}
