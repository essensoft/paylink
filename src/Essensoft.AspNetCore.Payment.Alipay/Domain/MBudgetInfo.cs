using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MBudgetInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MBudgetInfo : AlipayObject
    {
        /// <summary>
        /// 日预算设置必须在1~999999999范围内，不限制填写“-1”，注意：日预算不能大于总预算
        /// </summary>
        [JsonProperty("budget_daily")]
        public string BudgetDaily { get; set; }

        /// <summary>
        /// 总预算设置必须在1~999999999范围内，不限制填写“-1”
        /// </summary>
        [JsonProperty("budget_total")]
        public string BudgetTotal { get; set; }

        /// <summary>
        /// 预算类型，支持枚举：数量预算：QUANTITY
        /// </summary>
        [JsonProperty("budget_type")]
        public string BudgetType { get; set; }
    }
}
