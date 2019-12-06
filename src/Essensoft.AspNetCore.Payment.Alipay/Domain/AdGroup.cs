using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AdGroup Data Structure.
    /// </summary>
    public class AdGroup : AlipayObject
    {
        /// <summary>
        /// 广告系统ID
        /// </summary>
        [JsonPropertyName("ad_user_id")]
        public long AdUserId { get; set; }

        /// <summary>
        /// 人群定向（优化）配置串
        /// </summary>
        [JsonPropertyName("crowd_condition")]
        public string CrowdCondition { get; set; }

        /// <summary>
        /// 广告单元ID，新建时留空
        /// </summary>
        [JsonPropertyName("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 广告单元名称
        /// </summary>
        [JsonPropertyName("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 单元所属计划ID
        /// </summary>
        [JsonPropertyName("plan_id")]
        public long PlanId { get; set; }

        /// <summary>
        /// 区域定向
        /// </summary>
        [JsonPropertyName("position_condition")]
        public List<Position> PositionCondition { get; set; }

        /// <summary>
        /// 单元保量数值
        /// </summary>
        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }
    }
}
