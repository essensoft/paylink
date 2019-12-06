using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditLoanRefundCreateModel Data Structure.
    /// </summary>
    public class AlipayPcreditLoanRefundCreateModel : AlipayObject
    {
        /// <summary>
        /// 蚂蚁借呗贷款申请编号
        /// </summary>
        [JsonPropertyName("loan_apply_no")]
        public string LoanApplyNo { get; set; }

        /// <summary>
        /// 商户还款订单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户还款金额
        /// </summary>
        [JsonPropertyName("repay_amt")]
        public string RepayAmt { get; set; }

        /// <summary>
        /// 请求流水号，用于控制幂等
        /// </summary>
        [JsonPropertyName("req_id")]
        public string ReqId { get; set; }
    }
}
