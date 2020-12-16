using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ApiContractGoal Data Structure.
    /// </summary>
    public class ApiContractGoal : AlipayObject
    {
        /// <summary>
        /// 完成时间
        /// </summary>
        [JsonPropertyName("complete_date")]
        public string CompleteDate { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// 当前目标值
        /// </summary>
        [JsonPropertyName("goal_current_value")]
        public long GoalCurrentValue { get; set; }

        /// <summary>
        /// 标的key
        /// </summary>
        [JsonPropertyName("goal_key")]
        public string GoalKey { get; set; }

        /// <summary>
        /// cancel
        /// </summary>
        [JsonPropertyName("goal_status")]
        public string GoalStatus { get; set; }

        /// <summary>
        /// time、amount、subject
        /// </summary>
        [JsonPropertyName("goal_type")]
        public string GoalType { get; set; }

        /// <summary>
        /// 标的目标值
        /// </summary>
        [JsonPropertyName("goal_value")]
        public long GoalValue { get; set; }

        /// <summary>
        /// 事项号
        /// </summary>
        [JsonPropertyName("item_no")]
        public string ItemNo { get; set; }

        /// <summary>
        /// 最后一次完成时间
        /// </summary>
        [JsonPropertyName("last_complete_date")]
        public string LastCompleteDate { get; set; }
    }
}
