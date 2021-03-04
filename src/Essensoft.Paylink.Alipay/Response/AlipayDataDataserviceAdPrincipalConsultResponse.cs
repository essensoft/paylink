using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPrincipalConsultResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPrincipalConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 签约平台地址
        /// </summary>
        [JsonPropertyName("sign_url")]
        public string SignUrl { get; set; }
    }
}
