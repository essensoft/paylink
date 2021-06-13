using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAlipaypointBudgetlibQueryModel Data Structure.
    /// </summary>
    public class AlipayUserAlipaypointBudgetlibQueryModel : AlipayObject
    {
        /// <summary>
        /// 集分宝预算库编码
        /// </summary>
        [JsonPropertyName("budget_code")]
        public string BudgetCode { get; set; }
    }
}
