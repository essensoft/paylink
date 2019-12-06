using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CashCampaignInfo Data Structure.
    /// </summary>
    public class CashCampaignInfo : AlipayObject
    {
        /// <summary>
        /// 活动状态
        /// </summary>
        [JsonPropertyName("camp_status")]
        public string CampStatus { get; set; }

        /// <summary>
        /// 现金红包名称
        /// </summary>
        [JsonPropertyName("coupon_name")]
        public string CouponName { get; set; }

        /// <summary>
        /// 现金红包活动号
        /// </summary>
        [JsonPropertyName("crowd_no")]
        public string CrowdNo { get; set; }

        /// <summary>
        /// 原始活动号,商户进行问题排查时提供
        /// </summary>
        [JsonPropertyName("origin_crowd_no")]
        public string OriginCrowdNo { get; set; }
    }
}
