using System.Xml.Serialization;
using Newtonsoft.Json;

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
        [JsonProperty("expired_date")]
        [XmlElement("expired_date")]
        public string ExpiredDate { get; set; }

        /// <summary>
        /// 地铁购票二维码编码，可自定义
        /// </summary>
        [JsonProperty("qr_code_no")]
        [XmlElement("qr_code_no")]
        public string QrCodeNo { get; set; }

        /// <summary>
        /// 地铁购票的核销码
        /// </summary>
        [JsonProperty("ticket_no")]
        [XmlElement("ticket_no")]
        public string TicketNo { get; set; }
    }
}
