using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OpenPromoBudget Data Structure.
    /// </summary>
    public class OpenPromoBudget : AlipayObject
    {
        /// <summary>
        /// 预算数量，支持1～999999999之间。默认为999999999
        /// </summary>
        [JsonPropertyName("budget_total")]
        public string BudgetTotal { get; set; }

        /// <summary>
        /// 预算类型，现在支持CAMP_BUDGET_AMOUNT：表示数量预算
        /// </summary>
        [JsonPropertyName("budget_type")]
        public string BudgetType { get; set; }
    }
}
