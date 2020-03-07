using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditSupplychainTradePayableQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainTradePayableQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 待付金额，电票预付票据未到期=应付总金额-已付金额，票据到期兑付后=0
        /// </summary>
        [JsonPropertyName("debt_amt")]
        public string DebtAmt { get; set; }

        /// <summary>
        /// 应付到期日
        /// </summary>
        [JsonPropertyName("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 是否足额扣款（是则待付100必须一次性还清100）  本次电票预付该值为false
        /// </summary>
        [JsonPropertyName("if_enough")]
        public bool IfEnough { get; set; }

        /// <summary>
        /// 是否需要还款试算  如果付款的时候需要根据付款金额试算利息,费用的话,则该值会为true，本次电票预付该值为false
        /// </summary>
        [JsonPropertyName("if_need_budget")]
        public bool IfNeedBudget { get; set; }

        /// <summary>
        /// 逾期金额，电票预付到期兑付后若发生垫款，则该值=垫款（代偿）金额
        /// </summary>
        [JsonPropertyName("overdue_amt")]
        public string OverdueAmt { get; set; }

        /// <summary>
        /// 已付金额，电票预付对应已追加保证金金额
        /// </summary>
        [JsonPropertyName("paid_amt")]
        public string PaidAmt { get; set; }

        /// <summary>
        /// 应付总金额，电票预付对应订单金额
        /// </summary>
        [JsonPropertyName("total_amt")]
        public string TotalAmt { get; set; }
    }
}
