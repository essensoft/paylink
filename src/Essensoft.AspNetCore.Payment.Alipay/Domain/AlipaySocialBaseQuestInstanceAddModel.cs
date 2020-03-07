using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseQuestInstanceAddModel Data Structure.
    /// </summary>
    public class AlipaySocialBaseQuestInstanceAddModel : AlipayObject
    {
        /// <summary>
        /// 目标ID
        /// </summary>
        [JsonPropertyName("quest_id")]
        public string QuestId { get; set; }

        /// <summary>
        /// 每日打卡提醒时间范围，小目标提醒时间会在这个范围随机设定，时间格式HH-MM，开始时间和结束时间-分割。
        /// </summary>
        [JsonPropertyName("remind_time_range")]
        public string RemindTimeRange { get; set; }

        /// <summary>
        /// 调用方标识
        /// </summary>
        [JsonPropertyName("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
