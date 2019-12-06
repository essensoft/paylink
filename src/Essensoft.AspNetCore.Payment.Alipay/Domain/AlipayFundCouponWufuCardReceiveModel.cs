using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundCouponWufuCardReceiveModel Data Structure.
    /// </summary>
    public class AlipayFundCouponWufuCardReceiveModel : AlipayObject
    {
        /// <summary>
        /// 业务流水号，用于数据关联核对，不做为幂等使用。
        /// </summary>
        [JsonPropertyName("front_biz_no")]
        public string FrontBizNo { get; set; }

        /// <summary>
        /// 福卡领取场景
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
