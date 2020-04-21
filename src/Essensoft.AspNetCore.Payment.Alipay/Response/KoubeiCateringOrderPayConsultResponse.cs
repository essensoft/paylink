using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringOrderPayConsultResponse.
    /// </summary>
    public class KoubeiCateringOrderPayConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 优惠信息
        /// </summary>
        [JsonPropertyName("discount_details")]
        public List<DiscountDetail> DiscountDetails { get; set; }

        /// <summary>
        /// 储值卡信息
        /// </summary>
        [JsonPropertyName("m_card_detail")]
        public MCardDetail MCardDetail { get; set; }

        /// <summary>
        /// 用户实付金额，以元为单位，精确到分
        /// </summary>
        [JsonPropertyName("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 请求中的request_id。拿到结果后最好做下请求ID和返回的结果请求ID是否一致，防止万一请求串掉。
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 订单付款金额，以元为单位，精确到分
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }
    }
}
