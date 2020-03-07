using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMallScanpurchasePreorderCreateResponse.
    /// </summary>
    public class KoubeiMallScanpurchasePreorderCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 预订单编号
        /// </summary>
        [JsonPropertyName("advance_order_id")]
        public string AdvanceOrderId { get; set; }

        /// <summary>
        /// 二维码code
        /// </summary>
        [JsonPropertyName("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 二维码链接地址
        /// </summary>
        [JsonPropertyName("qr_code_url")]
        public string QrCodeUrl { get; set; }
    }
}
