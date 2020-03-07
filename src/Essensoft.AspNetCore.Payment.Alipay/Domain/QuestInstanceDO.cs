using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// QuestInstanceDO Data Structure.
    /// </summary>
    public class QuestInstanceDO : AlipayObject
    {
        /// <summary>
        /// 跳转地址:若用户已添加目标，则返回打卡页，否则返回目标详情页地址
        /// </summary>
        [JsonPropertyName("action_schema")]
        public string ActionSchema { get; set; }

        /// <summary>
        /// 用户当前获取卡片详情
        /// </summary>
        [JsonPropertyName("card_instance")]
        public CardInstanceDO CardInstance { get; set; }

        /// <summary>
        /// 卡片绑定的权益信息
        /// </summary>
        [JsonPropertyName("card_promos")]
        public List<CardPromoDO> CardPromos { get; set; }

        /// <summary>
        /// 用户已打卡天数
        /// </summary>
        [JsonPropertyName("day_count")]
        public long DayCount { get; set; }

        /// <summary>
        /// 小目标图标icon
        /// </summary>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 目标实例ID，若用户没有添加目标，则实例为空
        /// </summary>
        [JsonPropertyName("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 当前目标的添加人数
        /// </summary>
        [JsonPropertyName("join_count")]
        public string JoinCount { get; set; }

        /// <summary>
        /// 当前用户是否添加目标
        /// </summary>
        [JsonPropertyName("joined")]
        public bool Joined { get; set; }

        /// <summary>
        /// 是否已打卡
        /// </summary>
        [JsonPropertyName("marked")]
        public bool Marked { get; set; }

        /// <summary>
        /// 目标唯一ID
        /// </summary>
        [JsonPropertyName("quest_id")]
        public string QuestId { get; set; }

        /// <summary>
        /// 用户设定目标的提醒时间
        /// </summary>
        [JsonPropertyName("remind_times")]
        public List<string> RemindTimes { get; set; }

        /// <summary>
        /// 小目标标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
