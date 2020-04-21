using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorVoucherGenerateResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorVoucherGenerateResponse : AlipayResponse
    {
        /// <summary>
        /// 核销码过期时间
        /// </summary>
        [JsonPropertyName("expired_date")]
        public string ExpiredDate { get; set; }

        /// <summary>
        /// 地铁购票二维码编码，可自定义
        /// </summary>
        [JsonPropertyName("qr_code_no")]
        public string QrCodeNo { get; set; }

        /// <summary>
        /// 地铁购票的核销码
        /// </summary>
        [JsonPropertyName("ticket_no")]
        public string TicketNo { get; set; }
    }
}
