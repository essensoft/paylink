using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPointBudgetGetResponse.
    /// </summary>
    public class AlipayPointBudgetGetResponse : AlipayResponse
    {
        /// <summary>
        /// 还可以发放的集分宝个数
        /// </summary>
        [JsonPropertyName("budget_amount")]
        public long BudgetAmount { get; set; }
    }
}
