using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAssetPointBudgetQueryResponse.
    /// </summary>
    public class AlipayAssetPointBudgetQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 还可以发放的集分宝个数
        /// </summary>
        [JsonPropertyName("budget_amount")]
        public long BudgetAmount { get; set; }
    }
}
