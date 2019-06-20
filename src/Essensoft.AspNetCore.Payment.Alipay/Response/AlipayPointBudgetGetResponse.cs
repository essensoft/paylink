using Newtonsoft.Json;

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
        [JsonProperty("budget_amount")]
        public long BudgetAmount { get; set; }
    }
}
