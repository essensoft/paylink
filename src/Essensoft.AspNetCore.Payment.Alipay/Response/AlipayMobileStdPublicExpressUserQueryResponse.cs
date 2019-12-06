using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobileStdPublicExpressUserQueryResponse.
    /// </summary>
    public class AlipayMobileStdPublicExpressUserQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，身份证
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }
    }
}
