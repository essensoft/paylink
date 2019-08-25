using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BaseLoanApplyVO Data Structure.
    /// </summary>
    [Serializable]
    public class BaseLoanApplyVO : AlipayObject
    {
        /// <summary>
        /// 贷款申请金额
        /// </summary>
        [JsonProperty("apply_amt")]
        public string ApplyAmt { get; set; }

        /// <summary>
        /// 申请时间，即用户提交贷款申请的时间
        /// </summary>
        [JsonProperty("apply_date")]
        public string ApplyDate { get; set; }

        /// <summary>
        /// 贷款申请受理单号
        /// </summary>
        [JsonProperty("apply_receipt_no")]
        public string ApplyReceiptNo { get; set; }

        /// <summary>
        /// 贷款期限，包含贷款期数和期数单位
        /// </summary>
        [JsonProperty("loan_term")]
        public LoanTerm LoanTerm { get; set; }

        /// <summary>
        /// 贷款申请状态，取值{SUBMITTED, LENDING, USING, OVD, CLEAR, FAILED}：SUBMITTED-已提交; LENDING-放款中; USING-使用中; OVD-已逾期; CLEAR-已结清; FAILED-已失败
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
