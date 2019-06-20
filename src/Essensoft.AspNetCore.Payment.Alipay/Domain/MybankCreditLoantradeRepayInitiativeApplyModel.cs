using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditLoantradeRepayInitiativeApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradeRepayInitiativeApplyModel : AlipayObject
    {
        /// <summary>
        /// 贷款合约编号，用于指定还款对应的单合约合约编号。
        /// </summary>
        [JsonProperty("loan_ar_no")]
        public string LoanArNo { get; set; }

        /// <summary>
        /// 还款账户
        /// </summary>
        [JsonProperty("repay_account")]
        public Account RepayAccount { get; set; }

        /// <summary>
        /// 指定还款金额，单位人民币元，金额需要对应还款金额策略一起使用。
        /// </summary>
        [JsonProperty("repay_amount")]
        public string RepayAmount { get; set; }

        /// <summary>
        /// 指定还款金额对应的金额策略，目前支持：PRIN_AMT（指定本金还款）、CLEAR（结清还款）。
        /// </summary>
        [JsonProperty("repay_amount_strategy")]
        public string RepayAmountStrategy { get; set; }

        /// <summary>
        /// 指定还款客户会员，此处必须是贷款合约上对应的还款人的会员信息。
        /// </summary>
        [JsonProperty("repay_customer")]
        public Member RepayCustomer { get; set; }

        /// <summary>
        /// 还款日期。
        /// </summary>
        [JsonProperty("repay_date")]
        public string RepayDate { get; set; }

        /// <summary>
        /// 接口幂等字段，相同requestId请求系统默认认为是相同的请求。此处requestId要求的格式为"{机构IpRoleId}_{机构生成的唯一请求ID}"
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 此参数可选，由于下游银行并不一定能指定备注信息，所以该字段只对部分银行或内部账户打款时能生效。
        /// </summary>
        [JsonProperty("trans_memo")]
        public string TransMemo { get; set; }
    }
}
