using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// MybankCreditSupplychainPoolCreditsignadmitQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainPoolCreditsignadmitQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前授信是否准入，准入时返回true会有授信额度和可贷额度
        /// </summary>
        [JsonPropertyName("admit")]
        public string Admit { get; set; }

        /// <summary>
        /// 金额币种
        /// </summary>
        [JsonPropertyName("amt_ccy")]
        public string AmtCcy { get; set; }

        /// <summary>
        /// 授信额度，单位: 元
        /// </summary>
        [JsonPropertyName("credit_lmt_amt")]
        public string CreditLmtAmt { get; set; }

        /// <summary>
        /// 保理签约状态:  NOT_SIGNED: 未签约 SIGNED_NOT_VALID: 已签约待生效 SIGNED_VALID: 已签约已生效 SIGNED_INVALID: 已签约已失效
        /// </summary>
        [JsonPropertyName("factoring_sign_status")]
        public string FactoringSignStatus { get; set; }

        /// <summary>
        /// 贷款余额，单位: 元
        /// </summary>
        [JsonPropertyName("loan_balance_amt")]
        public string LoanBalanceAmt { get; set; }

        /// <summary>
        /// 可贷额度，单位: 元
        /// </summary>
        [JsonPropertyName("loanable_amt")]
        public string LoanableAmt { get; set; }
    }
}
