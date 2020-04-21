using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AdPlan Data Structure.
    /// </summary>
    public class AdPlan : AlipayObject
    {
        /// <summary>
        /// 注册用户返回的用户ID
        /// </summary>
        [JsonPropertyName("ad_user_id")]
        public long AdUserId { get; set; }

        /// <summary>
        /// 广告投放预算，单位：分
        /// </summary>
        [JsonPropertyName("budget")]
        public long Budget { get; set; }

        /// <summary>
        /// 投放计划结束时间
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 计划中所属单元列表
        /// </summary>
        [JsonPropertyName("group_list")]
        public AdGroup GroupList { get; set; }

        /// <summary>
        /// 广告计划ID
        /// </summary>
        [JsonPropertyName("plan_id")]
        public long PlanId { get; set; }

        /// <summary>
        /// 广告计划名称
        /// </summary>
        [JsonPropertyName("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 计划保量
        /// </summary>
        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 投放计划开始时间
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }
    }
}
