using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CampBaseDto Data Structure.
    /// </summary>
    public class CampBaseDto : AlipayObject
    {
        /// <summary>
        /// 活动工单列表
        /// </summary>
        [JsonPropertyName("activity_orders")]
        public List<ActivityOrderDTO> ActivityOrders { get; set; }

        /// <summary>
        /// 活动审核状态，AUDITING为审核中,REJECT为驳回，不返回为成功
        /// </summary>
        [JsonPropertyName("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 是否自动续期，Y为是，N为否，为空表示否
        /// </summary>
        [JsonPropertyName("auto_delay_flag")]
        public string AutoDelayFlag { get; set; }

        /// <summary>
        /// 截至时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 招商状态,GOING招商中，ENDED招商结束，OFFLINE下架
        /// </summary>
        [JsonPropertyName("plan_status")]
        public string PlanStatus { get; set; }

        /// <summary>
        /// 启动时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 活动状态,CREATED:草稿，ENABLED：生效，DISABLED：无效，STARTED：启动，CLOSED：停止，FINISHED：完成
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 活动类型.DIRECT_SEND:直发奖,CONSUME_SEND:消费送
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
