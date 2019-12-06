using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MBudgetInfo Data Structure.
    /// </summary>
    public class MBudgetInfo : AlipayObject
    {
        /// <summary>
        /// 日预算设置必须在1~999999999范围内，不限制填写“-1”，注意：日预算不能大于总预算
        /// </summary>
        [JsonPropertyName("budget_daily")]
        public string BudgetDaily { get; set; }

        /// <summary>
        /// 总预算设置必须在1~999999999范围内，不限制填写“-1”
        /// </summary>
        [JsonPropertyName("budget_total")]
        public string BudgetTotal { get; set; }

        /// <summary>
        /// 预算类型，支持枚举：数量预算：QUANTITY
        /// </summary>
        [JsonPropertyName("budget_type")]
        public string BudgetType { get; set; }
    }
}
