using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiTradeOrderConsultResponse.
    /// </summary>
    public class KoubeiTradeOrderConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 用户实付金额
        /// </summary>
        [JsonProperty("buyer_pay_amount")]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 优惠信息
        /// </summary>
        [JsonProperty("discount_detail")]
        public List<DiscountDetail> DiscountDetail { get; set; }

        /// <summary>
        /// 储值卡信息
        /// </summary>
        [JsonProperty("m_card_detail")]
        public MCardDetail MCardDetail { get; set; }

        /// <summary>
        /// 请求中的request_id
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }
}
