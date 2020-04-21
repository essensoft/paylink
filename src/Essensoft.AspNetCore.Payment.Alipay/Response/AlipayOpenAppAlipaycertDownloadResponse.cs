using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppAlipaycertDownloadResponse.
    /// </summary>
    public class AlipayOpenAppAlipaycertDownloadResponse : AlipayResponse
    {
        /// <summary>
        /// 公钥证书Base64后的字符串
        /// </summary>
        [JsonPropertyName("alipay_cert_content")]
        public string AlipayCertContent { get; set; }
    }
}
