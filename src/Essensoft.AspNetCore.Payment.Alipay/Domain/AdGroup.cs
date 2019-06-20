using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AdGroup Data Structure.
    /// </summary>
    [Serializable]
    public class AdGroup : AlipayObject
    {
        /// <summary>
        /// 广告系统ID
        /// </summary>
        [JsonProperty("ad_user_id")]
        public long AdUserId { get; set; }

        /// <summary>
        /// 人群定向（优化）配置串
        /// </summary>
        [JsonProperty("crowd_condition")]
        public string CrowdCondition { get; set; }

        /// <summary>
        /// 广告单元ID，新建时留空
        /// </summary>
        [JsonProperty("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 广告单元名称
        /// </summary>
        [JsonProperty("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 单元所属计划ID
        /// </summary>
        [JsonProperty("plan_id")]
        public long PlanId { get; set; }

        /// <summary>
        /// 区域定向
        /// </summary>
        [JsonProperty("position_condition")]
        public List<Position> PositionCondition { get; set; }

        /// <summary>
        /// 单元保量数值
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }
    }
}
