using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditLoanRepayResultQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanRepayResultQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 还款申请拒绝码
        /// </summary>
        [JsonPropertyName("reject_code")]
        public string RejectCode { get; set; }

        /// <summary>
        /// 还款申请拒绝描述
        /// </summary>
        [JsonPropertyName("reject_message")]
        public string RejectMessage { get; set; }

        /// <summary>
        /// 还款申请状态，取值{I, F, S}：I-初始化, F-还款失败; S-还款成功;
        /// </summary>
        [JsonPropertyName("repay_status")]
        public string RepayStatus { get; set; }
    }
}
