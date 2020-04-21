using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCustomerEpIdentificationQueryResponse.
    /// </summary>
    public class ZhimaCustomerEpIdentificationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 认证的企业证件号。
        /// </summary>
        [JsonPropertyName("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 认证的企业名。
        /// </summary>
        [JsonPropertyName("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 认证不通过的错误码。
        /// </summary>
        [JsonPropertyName("failed_code")]
        public string FailedCode { get; set; }

        /// <summary>
        /// 认证是否通过，通过为true，不通过为false。
        /// </summary>
        [JsonPropertyName("passed")]
        public string Passed { get; set; }
    }
}
