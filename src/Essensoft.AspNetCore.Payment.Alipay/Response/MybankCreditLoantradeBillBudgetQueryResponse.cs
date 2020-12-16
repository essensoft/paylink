using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditLoantradeBillBudgetQueryResponse.
    /// </summary>
    public class MybankCreditLoantradeBillBudgetQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 预算明细
        /// </summary>
        [JsonPropertyName("bill_repay_budget")]
        public BillRepayBudgetVO BillRepayBudget { get; set; }

        /// <summary>
        /// 不可见不可用信息
        /// </summary>
        [JsonPropertyName("refuse_msg")]
        public RefuseVo RefuseMsg { get; set; }

        /// <summary>
        /// 标识本次请求是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
