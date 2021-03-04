using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppQrcodeCreateResponse.
    /// </summary>
    public class AlipayOpenAppQrcodeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 二维码图片链接地址
        /// </summary>
        [JsonPropertyName("qr_code_url")]
        public string QrCodeUrl { get; set; }
    }
}
