using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InteligentBudgetInfo Data Structure.
    /// </summary>
    public class InteligentBudgetInfo : AlipayObject
    {
        /// <summary>
        /// 预算数量
        /// </summary>
        [JsonPropertyName("budget_total")]
        public string BudgetTotal { get; set; }

        /// <summary>
        /// 预算类型，枚举（QUANTITY：数量预算）
        /// </summary>
        [JsonPropertyName("budget_type")]
        public string BudgetType { get; set; }
    }
}
