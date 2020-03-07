using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundCouponWufuCardQueryModel Data Structure.
    /// </summary>
    public class AlipayFundCouponWufuCardQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务场景码
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
