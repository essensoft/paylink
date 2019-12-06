using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MEquityWorthInfo Data Structure.
    /// </summary>
    public class MEquityWorthInfo : AlipayObject
    {
        /// <summary>
        /// 权益价值信息计算方式，取值枚举：固定计算：FIXED、动态计算：DYNAMIC
        /// </summary>
        [JsonPropertyName("calculate_type")]
        public string CalculateType { get; set; }

        /// <summary>
        /// 代金的面额(单位分),取值范围1~499999的整数，仅当type=CASH该字段必填
        /// </summary>
        [JsonPropertyName("cash_amount")]
        public long CashAmount { get; set; }

        /// <summary>
        /// 权益面额动态规则类型，枚举值：阶梯满减：MULTI_STEP_CASH，仅当calculate_type=DYNAMIC时，该值必填
        /// </summary>
        [JsonPropertyName("dynamic_rule_type")]
        public string DynamicRuleType { get; set; }

        /// <summary>
        /// 最高优惠金额(单位:分)，最高优惠金额设置范围必须在1~499999的整数，只有type=RATE时生效，其他类型无需设置
        /// </summary>
        [JsonPropertyName("max_discount_amount")]
        public string MaxDiscountAmount { get; set; }

        /// <summary>
        /// 最高优惠件数，最高优惠件数设置范围值必须在1~99的整数，只有使用限制存在item_info_list单品信息时生效，其他情况无需设置
        /// </summary>
        [JsonPropertyName("max_discount_count")]
        public long MaxDiscountCount { get; set; }

        /// <summary>
        /// 阶梯满减阶梯信息，仅当dynamic_rule_type=MULTI_STEP_CASH时，该值必填
        /// </summary>
        [JsonPropertyName("multi_step_cash_rules")]
        public List<MStepCashRule> MultiStepCashRules { get; set; }

        /// <summary>
        /// 折扣率，取值范围0.11~0.99，至多2位小数，且仅当type=RATE时该值必填
        /// </summary>
        [JsonPropertyName("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// 减至的金额(单位分)，仅当type=REDUCE_TO时，该值必填
        /// </summary>
        [JsonPropertyName("reduce_to_amount")]
        public long ReduceToAmount { get; set; }

        /// <summary>
        /// 抹零规则，枚举值：不自动抹零：NOT_AUTO_ROUNDING、自动抹零到元：AUTO_ROUNDING_YUAN、自动抹零到角：AUTO_ROUNDING_JIAO、四舍五入到元：ROUNDING_UP_YUAN、四舍五入到角：ROUNDING_UP_JIAO，且当type=RATE时该值必填
        /// </summary>
        [JsonPropertyName("rounding_type")]
        public string RoundingType { get; set; }

        /// <summary>
        /// 权益价值类型；枚举值：代金：CASH、折扣：RATE、减至：REDUCE_TO，且仅当calculate_type=FIXED，该字段必填
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
