using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// QRcode Data Structure.
    /// </summary>
    public class QRcode : AlipayObject
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonPropertyName("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// qrcode地址
        /// </summary>
        [JsonPropertyName("qrcode_url")]
        public string QrcodeUrl { get; set; }
    }
}
