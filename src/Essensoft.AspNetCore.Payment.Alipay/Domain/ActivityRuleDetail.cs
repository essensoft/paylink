using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ActivityRuleDetail Data Structure.
    /// </summary>
    public class ActivityRuleDetail : AlipayObject
    {
        /// <summary>
        /// 活动规则中用户承诺消费的金额，当consume_type为CONSUME_AMOUNT时启用，单位为元
        /// </summary>
        [JsonPropertyName("rule_amount")]
        public long RuleAmount { get; set; }

        /// <summary>
        /// 活动规则中用户满足承诺可享受的优惠，单位百分，值为1-100之间，如88折传88，7折传70
        /// </summary>
        [JsonPropertyName("rule_discount")]
        public long RuleDiscount { get; set; }

        /// <summary>
        /// 承诺消费活动规则周期，单位默认为天，如果传rule_period_unit则和unit组合。
        /// </summary>
        [JsonPropertyName("rule_period")]
        public long RulePeriod { get; set; }

        /// <summary>
        /// YEAR - 年  MONTH - 月  WEEK - 星期  DAY - 天
        /// </summary>
        [JsonPropertyName("rule_period_unit")]
        public string RulePeriodUnit { get; set; }

        /// <summary>
        /// 活动规则中用户承诺消费次数，当rule_type为CONSUME_TIMES时启用，单位为次。
        /// </summary>
        [JsonPropertyName("rule_times")]
        public long RuleTimes { get; set; }
    }
}
