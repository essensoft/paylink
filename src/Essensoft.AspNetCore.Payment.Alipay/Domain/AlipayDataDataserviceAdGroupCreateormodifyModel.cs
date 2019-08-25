using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdGroupCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdGroupCreateormodifyModel : AlipayObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [JsonProperty("biz_token")]
        public string BizToken { get; set; }

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
        /// 单元名称
        /// </summary>
        [JsonProperty("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 外部单元编号
        /// </summary>
        [JsonProperty("group_outer_id")]
        public string GroupOuterId { get; set; }

        /// <summary>
        /// 商品id列表
        /// </summary>
        [JsonProperty("item_id_list")]
        public List<string> ItemIdList { get; set; }

        /// <summary>
        /// 外部计划编号
        /// </summary>
        [JsonProperty("plan_outer_id")]
        public string PlanOuterId { get; set; }

        /// <summary>
        /// 单元定向列表
        /// </summary>
        [JsonProperty("targeting_list")]
        public List<OuterTargetingItem> TargetingList { get; set; }

        /// <summary>
        /// 投放区间内的投放时段
        /// </summary>
        [JsonProperty("time_option")]
        public string TimeOption { get; set; }
    }
}
