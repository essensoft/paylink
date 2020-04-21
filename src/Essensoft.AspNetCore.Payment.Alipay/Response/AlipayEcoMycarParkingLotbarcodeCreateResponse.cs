using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingLotbarcodeCreateResponse.
    /// </summary>
    public class AlipayEcoMycarParkingLotbarcodeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 返回二维码链接地址
        /// </summary>
        [JsonPropertyName("qrcode_url")]
        public string QrcodeUrl { get; set; }

        /// <summary>
        /// 返回状态：1为成功，0为失败
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
