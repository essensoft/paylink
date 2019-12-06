using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsMktPreUseCampaignDTO Data Structure.
    /// </summary>
    public class InsMktPreUseCampaignDTO : AlipayObject
    {
        /// <summary>
        /// 活动Id
        /// </summary>
        [JsonPropertyName("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [JsonPropertyName("campaign_name")]
        public string CampaignName { get; set; }

        /// <summary>
        /// 权益类型
        /// </summary>
        [JsonPropertyName("coupon_type")]
        public string CouponType { get; set; }

        /// <summary>
        /// 权益盖帽值
        /// </summary>
        [JsonPropertyName("coupon_upper_value")]
        public string CouponUpperValue { get; set; }

        /// <summary>
        /// 权益值
        /// </summary>
        [JsonPropertyName("coupon_value")]
        public string CouponValue { get; set; }

        /// <summary>
        /// 是否预核销通过
        /// </summary>
        [JsonPropertyName("pre_use")]
        public bool PreUse { get; set; }

        /// <summary>
        /// 预核销失败原因
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
