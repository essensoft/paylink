using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceTruspleLoanapplySubmitModel Data Structure.
    /// </summary>
    public class AnttechBlockchainFinanceTruspleLoanapplySubmitModel : AlipayObject
    {
        /// <summary>
        /// 实控人信息
        /// </summary>
        [JsonPropertyName("actual_controllers")]
        public List<BeneficialEntity> ActualControllers { get; set; }

        /// <summary>
        /// 资料附件列表
        /// </summary>
        [JsonPropertyName("attachments")]
        public List<FinAttachment> Attachments { get; set; }

        /// <summary>
        /// 受益人信息
        /// </summary>
        [JsonPropertyName("beneficiaries")]
        public List<BeneficialEntity> Beneficiaries { get; set; }

        /// <summary>
        /// 借款人类型,COMPANY 企业对公贷款 LEGAL_PERSON 法人个人贷款
        /// </summary>
        [JsonPropertyName("borrower_type")]
        public string BorrowerType { get; set; }

        /// <summary>
        /// 外部合作伙伴的授信申请编号
        /// </summary>
        [JsonPropertyName("external_credit_grant_id")]
        public string ExternalCreditGrantId { get; set; }

        /// <summary>
        /// 外部合作伙伴的贷款合同编号
        /// </summary>
        [JsonPropertyName("external_loan_id")]
        public string ExternalLoanId { get; set; }

        /// <summary>
        /// 外部合作伙伴的支用申请号
        /// </summary>
        [JsonPropertyName("external_loan_request_id")]
        public string ExternalLoanRequestId { get; set; }

        /// <summary>
        /// 外部产品码
        /// </summary>
        [JsonPropertyName("external_product_code")]
        public string ExternalProductCode { get; set; }

        /// <summary>
        /// 外部用户唯一标识
        /// </summary>
        [JsonPropertyName("external_user_id")]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// 机构代码
        /// </summary>
        [JsonPropertyName("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 贷款利率,精确到小数点后6位，如0.001585表示0.1585%
        /// </summary>
        [JsonPropertyName("interest_rate")]
        public string InterestRate { get; set; }

        /// <summary>
        /// 贷款金额，币种最小单位，如果是CNY，则单位分
        /// </summary>
        [JsonPropertyName("loan_amount")]
        public long LoanAmount { get; set; }

        /// <summary>
        /// 贷款金额币种
        /// </summary>
        [JsonPropertyName("loan_amount_currency")]
        public string LoanAmountCurrency { get; set; }

        /// <summary>
        /// 支付账号类型:ALIPAY  支付宝,OUT_BANK  银行
        /// </summary>
        [JsonPropertyName("loan_payment_account_type")]
        public string LoanPaymentAccountType { get; set; }

        /// <summary>
        /// 支付方式:自主支付,受托支付（定向支付）
        /// </summary>
        [JsonPropertyName("loan_payment_method")]
        public string LoanPaymentMethod { get; set; }

        /// <summary>
        /// 贷款用途
        /// </summary>
        [JsonPropertyName("loan_purpose")]
        public string LoanPurpose { get; set; }

        /// <summary>
        /// 额度类型：CREDIT - 信用，ORDER - 订单，MORTGAGE - 抵押
        /// </summary>
        [JsonPropertyName("loan_quota_type")]
        public string LoanQuotaType { get; set; }

        /// <summary>
        /// 贷款期限,分期的期数,一次性到期还本付息则传1
        /// </summary>
        [JsonPropertyName("loan_term")]
        public long LoanTerm { get; set; }

        /// <summary>
        /// 贷款期限单位
        /// </summary>
        [JsonPropertyName("loan_term_unit")]
        public string LoanTermUnit { get; set; }

        /// <summary>
        /// 罚息利率,精确到小数点后6位，如0.004585表示0.4585%
        /// </summary>
        [JsonPropertyName("penalty_rate")]
        public string PenaltyRate { get; set; }

        /// <summary>
        /// 利率单位,ANNUAL 年化利率,DAILY 日利率
        /// </summary>
        [JsonPropertyName("rate_unit")]
        public string RateUnit { get; set; }

        /// <summary>
        /// 收款账户信息
        /// </summary>
        [JsonPropertyName("receive_account")]
        public BankAccount ReceiveAccount { get; set; }

        /// <summary>
        /// 固定还款日
        /// </summary>
        [JsonPropertyName("regular_repay_day")]
        public long RegularRepayDay { get; set; }

        /// <summary>
        /// 还款日类型,FIXED_MONTH_INTERVAL 放款日对月对日 ,FIXED_DATE 固定还款日
        /// </summary>
        [JsonPropertyName("repay_day_type")]
        public string RepayDayType { get; set; }

        /// <summary>
        /// 还款方式,REPAY_OUTRIGHT 到期一次性还本付息 BALLOON_MORTGAGE  按期付息，到期还本
        /// </summary>
        [JsonPropertyName("repay_mode")]
        public string RepayMode { get; set; }

        /// <summary>
        /// 订单贷贸易信息
        /// </summary>
        [JsonPropertyName("trade_info")]
        public TradeInformation TradeInfo { get; set; }
    }
}
