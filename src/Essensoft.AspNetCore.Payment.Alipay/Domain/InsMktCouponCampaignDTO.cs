using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsMktCouponCampaignDTO Data Structure.
    /// </summary>
    public class InsMktCouponCampaignDTO : AlipayObject
    {
        /// <summary>
        /// 活动核销截止时间
        /// </summary>
        [JsonPropertyName("campaign_end_time")]
        public string CampaignEndTime { get; set; }

        /// <summary>
        /// 活动Id
        /// </summary>
        [JsonPropertyName("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// 活动备注
        /// </summary>
        [JsonPropertyName("campaign_memo")]
        public string CampaignMemo { get; set; }

        /// <summary>
        /// 活动描述
        /// </summary>
        [JsonPropertyName("campaign_name")]
        public string CampaignName { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [JsonPropertyName("campaign_start_time")]
        public string CampaignStartTime { get; set; }

        /// <summary>
        /// 活动的权益类型描述
        /// </summary>
        [JsonPropertyName("coupon_type")]
        public string CouponType { get; set; }

        /// <summary>
        /// 权益盖帽值，如1000元优惠券
        /// </summary>
        [JsonPropertyName("coupon_upper_value")]
        public string CouponUpperValue { get; set; }

        /// <summary>
        /// 权益值，如500元优惠券
        /// </summary>
        [JsonPropertyName("coupon_value")]
        public string CouponValue { get; set; }
    }
}
