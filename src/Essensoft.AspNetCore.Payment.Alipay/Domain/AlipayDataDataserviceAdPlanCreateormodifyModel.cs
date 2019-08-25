using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdPlanCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdPlanCreateormodifyModel : AlipayObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [JsonProperty("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 日预算，单位：分
        /// </summary>
        [JsonProperty("budget")]
        public long Budget { get; set; }

        /// <summary>
        /// 计费方式：  CPC-按点击付费  CPM-按展示次数付费  CPD-按投放天数计费（包段）
        /// </summary>
        [JsonProperty("charge_type")]
        public string ChargeType { get; set; }

        /// <summary>
        /// 投放结束时间：yyyy-MM-dd
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 业务扩展参数字段，根据第三方需要使用，投放端只做存储并向检索端透传
        /// </summary>
        [JsonProperty("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 计划名称
        /// </summary>
        [JsonProperty("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 外部计划编号
        /// </summary>
        [JsonProperty("plan_outer_id")]
        public string PlanOuterId { get; set; }

        /// <summary>
        /// 商家id
        /// </summary>
        [JsonProperty("principal_id")]
        public long PrincipalId { get; set; }

        /// <summary>
        /// 售卖方式：  GD-保量投放  RTB-竞价交易
        /// </summary>
        [JsonProperty("sell_mode")]
        public string SellMode { get; set; }

        /// <summary>
        /// 投放开始时间：yyyy-MM-dd
        /// </summary>
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 投放时段配置，bitmap
        /// </summary>
        [JsonProperty("time_schema")]
        public string TimeSchema { get; set; }

        /// <summary>
        /// 账户id
        /// </summary>
        [JsonProperty("user_id")]
        public long UserId { get; set; }
    }
}
