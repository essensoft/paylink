using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorVoucherCancelModel Data Structure.
    /// </summary>
    public class AlipayCommerceCityfacilitatorVoucherCancelModel : AlipayObject
    {
        /// <summary>
        /// 渠道商提供的其它信息
        /// </summary>
        [JsonPropertyName("biz_info_ext")]
        public string BizInfoExt { get; set; }

        /// <summary>
        /// 城市标准码
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 商户退款时间
        /// </summary>
        [JsonPropertyName("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 核销号
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
