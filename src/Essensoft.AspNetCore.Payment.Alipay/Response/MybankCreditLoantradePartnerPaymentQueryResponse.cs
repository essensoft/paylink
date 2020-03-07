using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditLoantradePartnerPaymentQueryResponse.
    /// </summary>
    public class MybankCreditLoantradePartnerPaymentQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        [JsonPropertyName("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 网商内部申请单编号
        /// </summary>
        [JsonPropertyName("in_apply_no")]
        public string InApplyNo { get; set; }

        /// <summary>
        /// 申请结果
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
