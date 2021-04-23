using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceTruspleLoanapplySubmitResponse.
    /// </summary>
    public class AnttechBlockchainFinanceTruspleLoanapplySubmitResponse : AlipayResponse
    {
        /// <summary>
        /// Trusple借据号
        /// </summary>
        [JsonPropertyName("loan_id")]
        public string LoanId { get; set; }

        /// <summary>
        /// 结果状态，S表示成功，F表示明确失败，U表示未知异常。一般返回U，调用方可能会重试
        /// </summary>
        [JsonPropertyName("result_status")]
        public string ResultStatus { get; set; }
    }
}
