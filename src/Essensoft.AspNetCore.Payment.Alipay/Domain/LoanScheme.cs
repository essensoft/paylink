using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LoanScheme Data Structure.
    /// </summary>
    public class LoanScheme : AlipayObject
    {
        /// <summary>
        /// 授信有效截止日期(日期精度为天,包含截止日)
        /// </summary>
        [JsonPropertyName("credit_expire_date")]
        public string CreditExpireDate { get; set; }

        /// <summary>
        /// 授信额度，默认人民币，精确到小数点两位，单位元
        /// </summary>
        [JsonPropertyName("credit_lmt_amt")]
        public string CreditLmtAmt { get; set; }

        /// <summary>
        /// 授信编号
        /// </summary>
        [JsonPropertyName("credit_no")]
        public string CreditNo { get; set; }

        /// <summary>
        /// 授信方式
        /// </summary>
        [JsonPropertyName("credit_source")]
        public string CreditSource { get; set; }

        /// <summary>
        /// 授信有效起始日期(日期精度为天,包含起始日)
        /// </summary>
        [JsonPropertyName("credit_start_date")]
        public string CreditStartDate { get; set; }

        /// <summary>
        /// 利率. 年利率小数
        /// </summary>
        [JsonPropertyName("int_rate")]
        public string IntRate { get; set; }

        /// <summary>
        /// BC政策码
        /// </summary>
        [JsonPropertyName("loan_policy_code")]
        public string LoanPolicyCode { get; set; }

        /// <summary>
        /// 贷款期限
        /// </summary>
        [JsonPropertyName("loan_term")]
        public long LoanTerm { get; set; }

        /// <summary>
        /// 贷款期限单位
        /// </summary>
        [JsonPropertyName("loan_term_unit")]
        public string LoanTermUnit { get; set; }

        /// <summary>
        /// 可贷额度，默认人民币，精确到小数点两位，单位元
        /// </summary>
        [JsonPropertyName("loanable_amt")]
        public string LoanableAmt { get; set; }

        /// <summary>
        /// 统一还款日，若无统一还款日，则为空
        /// </summary>
        [JsonPropertyName("repay_day")]
        public long RepayDay { get; set; }

        /// <summary>
        /// 还款方式
        /// </summary>
        [JsonPropertyName("repay_mode")]
        public string RepayMode { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [JsonPropertyName("sale_pd_code")]
        public string SalePdCode { get; set; }

        /// <summary>
        /// 销售产品版本
        /// </summary>
        [JsonPropertyName("sale_pd_version")]
        public string SalePdVersion { get; set; }
    }
}
