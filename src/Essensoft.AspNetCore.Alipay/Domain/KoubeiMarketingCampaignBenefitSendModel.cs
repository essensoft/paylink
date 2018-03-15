using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignBenefitSendModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignBenefitSendModel : AlipayObject
    {
        /// <summary>
        /// 领券渠道
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 优惠类型
        /// </summary>
        [JsonProperty("discount_type")]
        public string DiscountType { get; set; }

        /// <summary>
        /// 触发权益的优惠id，当discount_type是ITEM的时候这个内容是商品id
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 外部流水号，用于控制幂等
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 领券的门店id
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
