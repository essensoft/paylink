using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountCashpoolRulegroupCreateModel Data Structure.
    /// </summary>
    public class AlipayAccountCashpoolRulegroupCreateModel : AlipayObject
    {
        /// <summary>
        /// 资金池唯一标识
        /// </summary>
        [JsonPropertyName("cash_pool_id")]
        public string CashPoolId { get; set; }

        /// <summary>
        /// 生效日期
        /// </summary>
        [JsonPropertyName("effective_time")]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 过期日期
        /// </summary>
        [JsonPropertyName("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 调拨额度配置
        /// </summary>
        [JsonPropertyName("inst_allocation_quota_vo_list")]
        public List<InstAllocationQuotaVO> InstAllocationQuotaVoList { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 外部单据号，做业务幂等使用
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 父账户目标水位
        /// </summary>
        [JsonPropertyName("parent_target_water_line")]
        public string ParentTargetWaterLine { get; set; }

        /// <summary>
        /// 规则组名称
        /// </summary>
        [JsonPropertyName("rule_group_name")]
        public string RuleGroupName { get; set; }

        /// <summary>
        /// 规则组类型，上划/下拨，UP_WARD_RULE/DOWN_WARD_RULE
        /// </summary>
        [JsonPropertyName("rule_group_type")]
        public string RuleGroupType { get; set; }

        /// <summary>
        /// 触发时间，填cron表达式
        /// </summary>
        [JsonPropertyName("trigger_time")]
        public string TriggerTime { get; set; }

        /// <summary>
        /// 规则组水位模式，主账户模式/子账户模式SUB_ACCOUNT_MODE/MAIN_ACCOUNT_MODE
        /// </summary>
        [JsonPropertyName("water_mode")]
        public string WaterMode { get; set; }
    }
}
