using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditLoanApplyQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanApplyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 贷款申请金额，目前只支持全额放款，所以申请金额和放款金额相同，以元为单位，精确到小数点后两位
        /// </summary>
        [JsonPropertyName("apply_amt")]
        public string ApplyAmt { get; set; }

        /// <summary>
        /// 用户贷款申请时间，格式：yyyy-MM-dd HH:mm:ss，为提交申请单据受理的时间
        /// </summary>
        [JsonPropertyName("apply_date")]
        public string ApplyDate { get; set; }

        /// <summary>
        /// 贷款合约编号，每笔用户贷款申请时，放款签约时生成的唯一合约编号，作为用户贷款账单的唯一标识。
        /// </summary>
        [JsonPropertyName("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 用户证件号，一般为用户身份证号，脱敏返回
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，和证件号cert_no配合使用，由平台定义，目前支持的证件类型有：  IDENTITY_CARD-身份证
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 授信编号，贷前申请额度的申请单号，在某些场景需要将支用申请和授信申请关联
        /// </summary>
        [JsonPropertyName("credit_no")]
        public string CreditNo { get; set; }

        /// <summary>
        /// 贷款日利率，最多精确到小数点后八位
        /// </summary>
        [JsonPropertyName("daily_int_rate")]
        public string DailyIntRate { get; set; }

        /// <summary>
        /// 贷款到期日，格式：yyyy-MM-dd HH:mm:ss，根据实际资金到账日期(注意非申请日期)结合贷款期限计算出的到期日期
        /// </summary>
        [JsonPropertyName("due_date")]
        public string DueDate { get; set; }

        /// <summary>
        /// 放款机构标识，由平台和商户共同约定
        /// </summary>
        [JsonPropertyName("encash_org")]
        public string EncashOrg { get; set; }

        /// <summary>
        /// 贷款申请单号，借呗客户申请贷款时系统生成的全局唯一业务流水号
        /// </summary>
        [JsonPropertyName("loan_apply_no")]
        public string LoanApplyNo { get; set; }

        /// <summary>
        /// 提前还款是否需要手续费，true-需要，false-不需要。具体费率见贷款合同说明
        /// </summary>
        [JsonPropertyName("need_prepayment_fee")]
        public bool NeedPrepaymentFee { get; set; }

        /// <summary>
        /// 放款到账时间，格式：yyyy-MM-dd HH:mm:ss，表示资金到账时间，也为合约生效日期
        /// </summary>
        [JsonPropertyName("payment_dt")]
        public string PaymentDt { get; set; }

        /// <summary>
        /// 还款方式，目前支持的还款方式有：  1-等额本息  2-等额本金  3-先息后本  6-到期一次还本付息
        /// </summary>
        [JsonPropertyName("repay_mode")]
        public string RepayMode { get; set; }

        /// <summary>
        /// 用户申请贷款的状态，目前有以下状态：  USING-使用中  OVD-逾期  CLEAR-结清
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 贷款期限，配合term_unit期限单位，或表示贷款天数或期数
        /// </summary>
        [JsonPropertyName("term")]
        public long Term { get; set; }

        /// <summary>
        /// 期限单位，和term配合使用，目前支持的期限单位有：  D-天  M-月  Y-年
        /// </summary>
        [JsonPropertyName("term_unit")]
        public string TermUnit { get; set; }

        /// <summary>
        /// 用户姓名，脱敏展示
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
