using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BudgetInfo Data Structure.
    /// </summary>
    public class BudgetInfo : AlipayObject
    {
        /// <summary>
        /// 预算数量
        /// </summary>
        [JsonPropertyName("budget_total")]
        public string BudgetTotal { get; set; }

        /// <summary>
        /// 预算类型
        /// </summary>
        [JsonPropertyName("budget_type")]
        public string BudgetType { get; set; }

        /// <summary>
        /// 设置每天的预算，如每天的预算设置为100，即该活动一天最多发放100次
        /// </summary>
        [JsonPropertyName("sub_budget_dimension")]
        public string SubBudgetDimension { get; set; }

        /// <summary>
        /// 用于控制子纬度的预算数量
        /// </summary>
        [JsonPropertyName("sub_value")]
        public string SubValue { get; set; }
    }
}
