using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCustomerEpCertificationQueryResponse.
    /// </summary>
    public class ZhimaCustomerEpCertificationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 认证不通过的原因
        /// </summary>
        [JsonPropertyName("failed_reason")]
        public string FailedReason { get; set; }

        /// <summary>
        /// 认证是否通过，通过为true，不通过为false
        /// </summary>
        [JsonPropertyName("passed")]
        public string Passed { get; set; }
    }
}
