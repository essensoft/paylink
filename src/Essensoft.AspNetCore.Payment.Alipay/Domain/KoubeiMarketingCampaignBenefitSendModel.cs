using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignBenefitSendModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignBenefitSendModel : AlipayObject
    {
        /// <summary>
        /// 身份证号码
        /// </summary>
        [JsonPropertyName("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 领券渠道
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 优惠类型，CAMPAIGN：活动，ITEM：商品
        /// </summary>
        [JsonPropertyName("discount_type")]
        public string DiscountType { get; set; }

        /// <summary>
        /// 是否需要控制发奖幂等
        /// </summary>
        [JsonPropertyName("idem_camp_trigger")]
        public bool IdemCampTrigger { get; set; }

        /// <summary>
        /// 触发权益的优惠id，当discount_type是ITEM的时候这个内容是商品id，当discount_type是CAMPAIGN的时候这个内容是活动id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 支付宝的登陆账号，可以为邮箱、手机号等。
        /// </summary>
        [JsonPropertyName("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [JsonPropertyName("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 外部流水号，用于控制幂等
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 领券的门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
