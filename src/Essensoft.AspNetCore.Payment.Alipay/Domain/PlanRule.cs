using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PlanRule Data Structure.
    /// </summary>
    public class PlanRule : AlipayObject
    {
        /// <summary>
        /// 当rule_type=FIXED 时,固定值有效
        /// </summary>
        [JsonPropertyName("fixed_value")]
        public string FixedValue { get; set; }

        /// <summary>
        /// 当rule_type=RANGE 时，range_end_value表示区间结束值
        /// </summary>
        [JsonPropertyName("range_end_value")]
        public string RangeEndValue { get; set; }

        /// <summary>
        /// 当rule_type=RANGE 时，range_start_value表示区间起始值
        /// </summary>
        [JsonPropertyName("range_start_value")]
        public string RangeStartValue { get; set; }

        /// <summary>
        /// voucher_type表示券的类型，目前只支持MONEY或RATE类型
        /// </summary>
        [JsonPropertyName("rule_desc")]
        public string RuleDesc { get; set; }

        /// <summary>
        /// 规则名称,目前只支持activity_type|活动类型,券类型|voucher_type,券数量|voucher_count,券logo| logo,代金券面额| worth_value,代金券券最低消费金额| mini_consume, 折扣| rate,最高优惠金额| max_amount,券的备注| voucher_note,券有效期类型| validate_type,券相对有效期| relative_time,绝对有效期开始时间| fix_start_time,绝对有效期结束时间| fix_end_time,券使用时间段|use_time,活动预算数量| budget_total,用户领取频次| user_win_frequency
        /// </summary>
        [JsonPropertyName("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// FIXED表示固定值，RANGE表示区间
        /// </summary>
        [JsonPropertyName("rule_type")]
        public string RuleType { get; set; }
    }
}
