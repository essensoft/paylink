using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ScheduleListItem Data Structure.
    /// </summary>
    public class ScheduleListItem : AlipayObject
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 任务状态枚举。 0：准备， 1：运行中  2：已完成  3： 失败
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 任务类型。枚举，参考任务类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
