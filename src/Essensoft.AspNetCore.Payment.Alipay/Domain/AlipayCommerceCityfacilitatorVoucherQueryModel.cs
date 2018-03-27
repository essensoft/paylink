using Newtonsoft.Json;

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
        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 8位核销码
        /// </summary>
        [JsonProperty("ticket_no")]
        public string TicketNo { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
