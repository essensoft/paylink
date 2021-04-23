using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// RpaCrawlerTaskVO Data Structure.
    /// </summary>
    public class RpaCrawlerTaskVO : AlipayObject
    {
        /// <summary>
        /// 算法id
        /// </summary>
        [JsonPropertyName("algo_id")]
        public string AlgoId { get; set; }

        /// <summary>
        /// 业务目标
        /// </summary>
        [JsonPropertyName("biz_goal")]
        public string BizGoal { get; set; }

        /// <summary>
        /// 创意列表
        /// </summary>
        [JsonPropertyName("creative_code_list")]
        public List<string> CreativeCodeList { get; set; }

        /// <summary>
        /// 创意包code
        /// </summary>
        [JsonPropertyName("creative_group_code")]
        public string CreativeGroupCode { get; set; }

        /// <summary>
        /// 创意包版本
        /// </summary>
        [JsonPropertyName("creative_group_version")]
        public string CreativeGroupVersion { get; set; }

        /// <summary>
        /// 人群列表
        /// </summary>
        [JsonPropertyName("crowd_id_list")]
        public List<string> CrowdIdList { get; set; }

        /// <summary>
        /// 单元名称
        /// </summary>
        [JsonPropertyName("deliver_unit_name")]
        public string DeliverUnitName { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 疲劳度
        /// </summary>
        [JsonPropertyName("fatigue")]
        public string Fatigue { get; set; }

        /// <summary>
        /// 计划code
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 展位码
        /// </summary>
        [JsonPropertyName("position_code")]
        public string PositionCode { get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonPropertyName("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 策略ID
        /// </summary>
        [JsonPropertyName("strategy_id")]
        public string StrategyId { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 白名单列表
        /// </summary>
        [JsonPropertyName("white_list")]
        public List<string> WhiteList { get; set; }
    }
}
