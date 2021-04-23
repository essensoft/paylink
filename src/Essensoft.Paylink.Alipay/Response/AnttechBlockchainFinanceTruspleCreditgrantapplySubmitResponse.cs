using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceTruspleCreditgrantapplySubmitResponse.
    /// </summary>
    public class AnttechBlockchainFinanceTruspleCreditgrantapplySubmitResponse : AlipayResponse
    {
        /// <summary>
        /// 机构授信编号
        /// </summary>
        [JsonPropertyName("inst_credit_grant_id")]
        public string InstCreditGrantId { get; set; }

        /// <summary>
        /// 结果状态，S表示成功，F表示明确失败，U表示未知异常。一般返回U，调用方可能会重试
        /// </summary>
        [JsonPropertyName("result_status")]
        public string ResultStatus { get; set; }
    }
}
