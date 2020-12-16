using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    public class AlipayOpenAppAlipaycertDownloadResponse : AlipayResponse
    {
        [JsonPropertyName("alipay_cert_content")]
        public string AlipayCertContent { get; set; }
    }
}
