using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorVoucherQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceCityfacilitatorVoucherQueryModel : AlipayObject
    {
        /// <summary>
        /// 城市标准码
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 8位核销码
        /// </summary>
        [JsonPropertyName("ticket_no")]
        public string TicketNo { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
