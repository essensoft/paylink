using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsMktPreUseCampaignDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsMktPreUseCampaignDTO : AlipayObject
    {
        /// <summary>
        /// 活动Id
        /// </summary>
        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [JsonProperty("campaign_name")]
        public string CampaignName { get; set; }

        /// <summary>
        /// 权益类型
        /// </summary>
        [JsonProperty("coupon_type")]
        public string CouponType { get; set; }

        /// <summary>
        /// 权益盖帽值
        /// </summary>
        [JsonProperty("coupon_upper_value")]
        public string CouponUpperValue { get; set; }

        /// <summary>
        /// 权益值
        /// </summary>
        [JsonProperty("coupon_value")]
        public string CouponValue { get; set; }

        /// <summary>
        /// 是否预核销通过
        /// </summary>
        [JsonProperty("pre_use")]
        public bool PreUse { get; set; }

        /// <summary>
        /// 预核销失败原因
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
