using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayItemLimitPeriodInfo Data Structure.
    /// </summary>
    public class AlipayItemLimitPeriodInfo : AlipayObject
    {
        /// <summary>
        /// 区间范围枚举，分为：  INCLUDE（包含）  EXCLUDE（排除）
        /// </summary>
        [JsonPropertyName("rule")]
        public string Rule { get; set; }

        /// <summary>
        /// 单位描述，分为：  MINUTE（分钟）  HOUR（小时）  WEEK_DAY（星期几）  DAY（日）  WEEK（周）  MONTH（月）  ALL（整个销售周期）
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// 区间范围值，参数类型为Number
        /// </summary>
        [JsonPropertyName("value")]
        public List<long> Value { get; set; }
    }
}
