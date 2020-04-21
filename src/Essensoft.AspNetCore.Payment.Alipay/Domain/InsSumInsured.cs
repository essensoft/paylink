using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsSumInsured Data Structure.
    /// </summary>
    public class InsSumInsured : AlipayObject
    {
        /// <summary>
        /// 保额默认值;单位分
        /// </summary>
        [JsonPropertyName("default_value")]
        public long DefaultValue { get; set; }

        /// <summary>
        /// 保额最大值;单位分,当sum_insured_type=MONEY_RANGE时该值有效
        /// </summary>
        [JsonPropertyName("max_value")]
        public long MaxValue { get; set; }

        /// <summary>
        /// 保额最小值;单位分,当sum_insured_type=MONEY_RANGE时该值有效
        /// </summary>
        [JsonPropertyName("min_value")]
        public long MinValue { get; set; }

        /// <summary>
        /// 保额类型;MONEY_RANGE:金额范围,MONEY_LIST:金额可选值,ENUM_VALUE:枚举值
        /// </summary>
        [JsonPropertyName("sum_insured_type")]
        public string SumInsuredType { get; set; }

        /// <summary>
        /// 保额列表;列表里的值单位为分,当sum_insured_type=MONEY_LIST时该值有效
        /// </summary>
        [JsonPropertyName("sum_insureds")]
        public List<long> SumInsureds { get; set; }
    }
}
