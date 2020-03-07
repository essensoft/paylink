using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditLoantradeNewloanarRepayApplyModel Data Structure.
    /// </summary>
    public class MybankCreditLoantradeNewloanarRepayApplyModel : AlipayObject
    {
        /// <summary>
        /// 申请还款费用，收费必填
        /// </summary>
        [JsonPropertyName("apply_repay_fee")]
        public string ApplyRepayFee { get; set; }

        /// <summary>
        /// 申请还款利息，收费必填
        /// </summary>
        [JsonPropertyName("apply_repay_int")]
        public string ApplyRepayInt { get; set; }

        /// <summary>
        /// 申请还款罚息，收费必填
        /// </summary>
        [JsonPropertyName("apply_repay_penalty")]
        public string ApplyRepayPenalty { get; set; }

        /// <summary>
        /// 申请还款本金，收费必填
        /// </summary>
        [JsonPropertyName("apply_repay_prin")]
        public string ApplyRepayPrin { get; set; }

        /// <summary>
        /// 贷款客户在网商的会员角色ID
        /// </summary>
        [JsonPropertyName("cust_iprole_id")]
        public string CustIproleId { get; set; }

        /// <summary>
        /// 贷款合约号
        /// </summary>
        [JsonPropertyName("loan_ar_no")]
        public string LoanArNo { get; set; }

        /// <summary>
        /// 还款金额，单位默认为元，支持小数点两位，为了便于传输，合作方需将数值型转换为字符串型
        /// </summary>
        [JsonPropertyName("repay_amt")]
        public string RepayAmt { get; set; }

        /// <summary>
        /// 网商结算户的卡号外标，若机构合约不是对客担保该账户必填
        /// </summary>
        [JsonPropertyName("repay_card_no")]
        public string RepayCardNo { get; set; }

        /// <summary>
        /// 还款类型，总额还款:TOTAL_AMT 本金还款:PRIN_AMT
        /// </summary>
        [JsonPropertyName("repay_type")]
        public string RepayType { get; set; }

        /// <summary>
        /// 外部流水号格式：日期(8位)+序列号(8位）,序列号是数字，如00000001（必须是16位且符合该格式）幂等字段，如果其他参数有变化，此字段需要修改。
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
