using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditLoanLoanResultQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanLoanResultQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 贷款申请状态，取值{SUBMITTED, LENDING, USING, OVD, CLEAR, FAILED}：SUBMITTED-已提交; LENDING-放款中; USING-使用中; OVD-已逾期; CLEAR-已结清; FAILED-已失败
        /// </summary>
        [JsonPropertyName("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 贷款申请拒绝码
        /// </summary>
        [JsonPropertyName("reject_code")]
        public string RejectCode { get; set; }

        /// <summary>
        /// 贷款申请拒绝说明
        /// </summary>
        [JsonPropertyName("reject_message")]
        public string RejectMessage { get; set; }
    }
}
