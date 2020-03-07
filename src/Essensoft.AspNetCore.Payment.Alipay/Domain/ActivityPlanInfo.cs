using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ActivityPlanInfo Data Structure.
    /// </summary>
    public class ActivityPlanInfo : AlipayObject
    {
        /// <summary>
        /// 平台活动结束时间
        /// </summary>
        [JsonPropertyName("activity_end_time")]
        public string ActivityEndTime { get; set; }

        /// <summary>
        /// 平台活动开始时间
        /// </summary>
        [JsonPropertyName("activity_start_time")]
        public string ActivityStartTime { get; set; }

        /// <summary>
        /// 招商结束时间
        /// </summary>
        [JsonPropertyName("confirm_end_time")]
        public string ConfirmEndTime { get; set; }

        /// <summary>
        /// 平台活动邀约工单号(需要在第三方活动中回传)
        /// </summary>
        [JsonPropertyName("invite_order_id")]
        public string InviteOrderId { get; set; }

        /// <summary>
        /// 规则描述
        /// </summary>
        [JsonPropertyName("plan_rule_list")]
        public List<PlanRule> PlanRuleList { get; set; }

        /// <summary>
        /// 是个链接地址，下载后是pdf文件
        /// </summary>
        [JsonPropertyName("plat_activity_agreement")]
        public string PlatActivityAgreement { get; set; }

        /// <summary>
        /// 平台活动id（需要在第三方方活动中回传）
        /// </summary>
        [JsonPropertyName("plat_activity_id")]
        public string PlatActivityId { get; set; }

        /// <summary>
        /// 平台活动标签类型
        /// </summary>
        [JsonPropertyName("plat_activity_label_type")]
        public string PlatActivityLabelType { get; set; }

        /// <summary>
        /// 平台活动名称
        /// </summary>
        [JsonPropertyName("plat_activity_name")]
        public string PlatActivityName { get; set; }

        /// <summary>
        /// 活动规则描述
        /// </summary>
        [JsonPropertyName("plat_activity_rule_desc")]
        public string PlatActivityRuleDesc { get; set; }

        /// <summary>
        /// 平台活动状态,GOING/FINISH,GOING表示招商中,FINISH表示招商已经结束(再报名活动也无法成功),只有GOING状态可以报名
        /// </summary>
        [JsonPropertyName("plat_activity_status")]
        public string PlatActivityStatus { get; set; }

        /// <summary>
        /// 其他说明
        /// </summary>
        [JsonPropertyName("plat_other_desc")]
        public string PlatOtherDesc { get; set; }
    }
}
