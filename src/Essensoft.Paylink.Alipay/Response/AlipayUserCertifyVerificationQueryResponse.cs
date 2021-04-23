using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayUserCertifyVerificationQueryResponse.
    /// </summary>
    public class AlipayUserCertifyVerificationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 核验不一致原因
        /// </summary>
        [JsonPropertyName("mismatch_reason")]
        public string MismatchReason { get; set; }

        /// <summary>
        /// 核验网络结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 业务结果信息
        /// </summary>
        [JsonPropertyName("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 核验源
        /// </summary>
        [JsonPropertyName("source_from")]
        public string SourceFrom { get; set; }
    }
}
