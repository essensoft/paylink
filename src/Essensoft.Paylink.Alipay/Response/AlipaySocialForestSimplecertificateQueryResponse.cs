using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipaySocialForestSimplecertificateQueryResponse.
    /// </summary>
    public class AlipaySocialForestSimplecertificateQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 证书ID
        /// </summary>
        [JsonPropertyName("cert_id")]
        public string CertId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
