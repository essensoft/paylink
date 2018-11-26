using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ShopDiscountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopDiscountInfo : AlipayObject
    {
        /// <summary>
        /// 图片url
        /// </summary>
        [JsonProperty("cover")]
        [XmlElement("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// 优惠信息描述
        /// </summary>
        [JsonProperty("description")]
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 是否全场。  全场：Y，单品：N
        /// </summary>
        [JsonProperty("is_all")]
        [XmlElement("is_all")]
        public string IsAll { get; set; }

        /// <summary>
        /// 支付宝商品id
        /// </summary>
        [JsonProperty("item_id")]
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 子类型
        /// </summary>
        [JsonProperty("promo_sub_type")]
        [XmlElement("promo_sub_type")]
        public string PromoSubType { get; set; }

        /// <summary>
        /// 优惠类型。  优惠：discount  商品：item
        /// </summary>
        [JsonProperty("promotion_type")]
        [XmlElement("promotion_type")]
        public string PromotionType { get; set; }

        /// <summary>
        /// 领用模式。自动领用：AUTO_OBTAIN。手动领用：OBTAIN
        /// </summary>
        [JsonProperty("purchase_mode")]
        [XmlElement("purchase_mode")]
        public string PurchaseMode { get; set; }

        /// <summary>
        /// 已用数量
        /// </summary>
        [JsonProperty("sales_quantity")]
        [XmlElement("sales_quantity")]
        public string SalesQuantity { get; set; }

        /// <summary>
        /// 优惠信息标题
        /// </summary>
        [JsonProperty("subject")]
        [XmlElement("subject")]
        public string Subject { get; set; }
    }
}
