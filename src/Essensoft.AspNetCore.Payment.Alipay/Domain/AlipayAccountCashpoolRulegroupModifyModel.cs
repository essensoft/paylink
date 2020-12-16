using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountCashpoolRulegroupModifyModel Data Structure.
    /// </summary>
    public class AlipayAccountCashpoolRulegroupModifyModel : AlipayObject
    {
        /// <summary>
        /// 资金池唯一标识
        /// </summary>
        [JsonPropertyName("cash_pool_id")]
        public string CashPoolId { get; set; }

        /// <summary>
        /// UP_WARD_RULE/DOWN_WARD_RULE;上划/下拨
        /// </summary>
        [JsonPropertyName("config_type")]
        public string ConfigType { get; set; }

        /// <summary>
        /// 调拨限额修改
        /// </summary>
        [JsonPropertyName("inst_allocation_quota_vo_list")]
        public List<InstAllocationQuotaVO> InstAllocationQuotaVoList { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 父账户目标水位
        /// </summary>
        [JsonPropertyName("parent_target_water_line")]
        public string ParentTargetWaterLine { get; set; }

        /// <summary>
        /// 规则组唯一标识
        /// </summary>
        [JsonPropertyName("rule_group_id")]
        public string RuleGroupId { get; set; }

        /// <summary>
        /// INITIAL/RUN/STOP，规则组状态，初始/运行/暂停
        /// </summary>
        [JsonPropertyName("rule_group_status")]
        public string RuleGroupStatus { get; set; }

        /// <summary>
        /// 规则触发的cron表达式
        /// </summary>
        [JsonPropertyName("trigger_time")]
        public string TriggerTime { get; set; }

        /// <summary>
        /// 子账户模式/主账户模式，SUB_ACCOUNT_MODE/MAIN_ACCOUNT_MODE
        /// </summary>
        [JsonPropertyName("water_mode")]
        public string WaterMode { get; set; }
    }
}
