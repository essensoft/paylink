using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
