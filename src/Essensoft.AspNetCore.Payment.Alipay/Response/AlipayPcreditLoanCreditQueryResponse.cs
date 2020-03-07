using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditLoanCreditQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanCreditQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户授信额度
        /// </summary>
        [JsonPropertyName("credit_amt")]
        public string CreditAmt { get; set; }

        /// <summary>
        /// 用户可用额度
        /// </summary>
        [JsonPropertyName("loanable_amt")]
        public string LoanableAmt { get; set; }

        /// <summary>
        /// 授信申请拒绝码
        /// </summary>
        [JsonPropertyName("reject_code")]
        public string RejectCode { get; set; }

        /// <summary>
        /// 授信申请拒绝说明
        /// </summary>
        [JsonPropertyName("reject_message")]
        public string RejectMessage { get; set; }

        /// <summary>
        /// 用户还款日
        /// </summary>
        [JsonPropertyName("repay_day")]
        public long RepayDay { get; set; }

        /// <summary>
        /// 贷款产品方案
        /// </summary>
        [JsonPropertyName("schema")]
        public SchemaVO Schema { get; set; }

        /// <summary>
        /// 用户准入与授信状态，取值范围{PASS, REJECT, PENDING, PROCESSING}：PASS-通过; REJECT-拒绝; PENDING-待申请; PROCESSING-申请处理中;
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
