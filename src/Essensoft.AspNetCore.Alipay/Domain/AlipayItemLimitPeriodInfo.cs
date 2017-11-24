using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayItemLimitPeriodInfo Data Structure.
    /// </summary>
    public class AlipayItemLimitPeriodInfo : AlipayObject
    {
        /// <summary>
        /// 区间范围枚举，分为：  INCLUDE（包含）  EXCLUDE（排除）
        /// </summary>
        [JsonProperty("rule")]
        public string Rule { get; set; }

        /// <summary>
        /// 单位描述，分为：  MINUTE（分钟）  HOUR（小时）  WEEK_DAY（星期几）  DAY（日）  WEEK（周）  MONTH（月）  ALL（整个销售周期）
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// 区间范围值，参数类型为Number
        /// </summary>
        [JsonProperty("value")]
        public List<long> Value { get; set; }
    }
}
