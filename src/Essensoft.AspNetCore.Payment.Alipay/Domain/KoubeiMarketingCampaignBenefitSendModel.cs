using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignBenefitSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignBenefitSendModel : AlipayObject
    {
        /// <summary>
        /// 领券渠道
        /// </summary>
        [JsonProperty("channel")]
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 优惠类型，CAMPAIGN：活动，ITEM：商品
        /// </summary>
        [JsonProperty("discount_type")]
        [XmlElement("discount_type")]
        public string DiscountType { get; set; }

        /// <summary>
        /// 触发权益的优惠id，当discount_type是ITEM的时候这个内容是商品id，当discount_type是CAMPAIGN的时候这个内容是活动id
        /// </summary>
        [JsonProperty("item_id")]
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 外部流水号，用于控制幂等
        /// </summary>
        [JsonProperty("out_biz_no")]
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 领券的门店id
        /// </summary>
        [JsonProperty("shop_id")]
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
