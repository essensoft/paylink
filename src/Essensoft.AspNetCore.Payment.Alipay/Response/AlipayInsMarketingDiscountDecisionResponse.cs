using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsMarketingDiscountDecisionResponse.
    /// </summary>
    public class AlipayInsMarketingDiscountDecisionResponse : AlipayResponse
    {
        /// <summary>
        /// 该订单可以享受的事后权益
        /// </summary>
        [JsonPropertyName("mkt_coupon_campaigns")]
        public List<InsMktCouponCampaignDTO> MktCouponCampaigns { get; set; }

        /// <summary>
        /// 本次优惠咨询可以使用的权益权益列表
        /// </summary>
        [JsonPropertyName("mkt_coupons")]
        public List<InsMktCouponDTO> MktCoupons { get; set; }
    }
}
