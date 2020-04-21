using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTravelRatePromotionVerifyModel Data Structure.
    /// </summary>
    public class AlipayOverseasTravelRatePromotionVerifyModel : AlipayObject
    {
        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [JsonPropertyName("extend_param")]
        public string ExtendParam { get; set; }

        /// <summary>
        /// 跨境游发现平台优惠id
        /// </summary>
        [JsonPropertyName("travel_promotion_id")]
        public string TravelPromotionId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
