using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayFundCouponWufuCardApplyModel Data Structure.
    /// </summary>
    public class AlipayFundCouponWufuCardApplyModel : AlipayObject
    {
        /// <summary>
        /// 唯一请求码
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [JsonPropertyName("sence_code")]
        public string SenceCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
