using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OuterGroup Data Structure.
    /// </summary>
    [Serializable]
    public class OuterGroup : AlipayObject
    {
        /// <summary>
        /// 业务扩展参数字段，根据第三方需要使用，投放端只做存储并向检索端透传
        /// </summary>
        [JsonProperty("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 单元出价，单位：分
        /// </summary>
        [JsonProperty("group_charge")]
        public long GroupCharge { get; set; }

        /// <summary>
        /// 单元id
        /// </summary>
        [JsonProperty("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 单元名称
        /// </summary>
        [JsonProperty("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 外部唯一单元编号
        /// </summary>
        [JsonProperty("group_outer_id")]
        public string GroupOuterId { get; set; }

        /// <summary>
        /// 单元状态： ENABLE-生效 DISABLE-暂停 DELETE-已删除 INIT-初始化 REAL_DISABLE-失效
        /// </summary>
        [JsonProperty("group_status")]
        public string GroupStatus { get; set; }

        /// <summary>
        /// 商品id列表
        /// </summary>
        [JsonProperty("item_id_list")]
        public List<string> ItemIdList { get; set; }

        /// <summary>
        /// 外部唯一计划编号
        /// </summary>
        [JsonProperty("plan_outer_id")]
        public string PlanOuterId { get; set; }

        /// <summary>
        /// 单元定向列表。目前支持的定向类型有：  REGION_LIST: 实时地址  AD_POS_LIST: 广告位定向  OUTER_KOUBEI_INTEREST_TAG_LIST: 口碑偏好  OUTER_KOUBEI_CROWD_TAG_LIST：口碑人群
        /// </summary>
        [JsonProperty("targeting_list")]
        public List<OuterTargetingItem> TargetingList { get; set; }

        /// <summary>
        /// 投放区间内的投放时段
        /// </summary>
        [JsonProperty("time_option")]
        public string TimeOption { get; set; }

        /// <summary>
        /// 投放时段配置，bitmap。规则：7个int用「,」分隔组成的字符串；每个int中第0位表示0点，第1位表示1点。如此类推; 7个int的排序是星期日、星期一、星期二、星期三、星期四、星期五、星期六
        /// </summary>
        [JsonProperty("time_schema")]
        public string TimeSchema { get; set; }
    }
}
