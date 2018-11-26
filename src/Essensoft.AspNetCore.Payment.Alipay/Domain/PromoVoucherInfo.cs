using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PromoVoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PromoVoucherInfo : AlipayObject
    {
        /// <summary>
        /// 折扣（折扣券类型才有）
        /// </summary>
        [JsonProperty("discount")]
        [XmlElement("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 是否是自动领取券
        /// </summary>
        [JsonProperty("is_auto_obtain")]
        [XmlElement("is_auto_obtain")]
        public string IsAutoObtain { get; set; }

        /// <summary>
        /// 是否是商圈发的券 true/false
        /// </summary>
        [JsonProperty("is_mall_voucher")]
        [XmlElement("is_mall_voucher")]
        public string IsMallVoucher { get; set; }

        /// <summary>
        /// 券品牌名称
        /// </summary>
        [JsonProperty("item_brand_name")]
        [XmlElement("item_brand_name")]
        public string ItemBrandName { get; set; }

        /// <summary>
        /// 券有效期结束时间
        /// </summary>
        [JsonProperty("item_gmt_end")]
        [XmlElement("item_gmt_end")]
        public string ItemGmtEnd { get; set; }

        /// <summary>
        /// 商品有效期开始时间
        /// </summary>
        [JsonProperty("item_gmt_start")]
        [XmlElement("item_gmt_start")]
        public string ItemGmtStart { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("item_id")]
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 券图片地址
        /// </summary>
        [JsonProperty("item_logo")]
        [XmlElement("item_logo")]
        public string ItemLogo { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("item_name")]
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 买a送b 送单品名称
        /// </summary>
        [JsonProperty("send_item_name")]
        [XmlElement("send_item_name")]
        public string SendItemName { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [JsonProperty("shop_id")]
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonProperty("shop_name")]
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 券使用门槛金额(元)
        /// </summary>
        [JsonProperty("use_condition_amount")]
        [XmlElement("use_condition_amount")]
        public string UseConditionAmount { get; set; }

        /// <summary>
        /// 代金券 减至券 兑换券 换购券 金额
        /// </summary>
        [JsonProperty("value_amount")]
        [XmlElement("value_amount")]
        public string ValueAmount { get; set; }

        /// <summary>
        /// 券跳转地址(h5)
        /// </summary>
        [JsonProperty("voucher_detail_url")]
        [XmlElement("voucher_detail_url")]
        public string VoucherDetailUrl { get; set; }

        /// <summary>
        /// DISCOUNT_ALL, // 折扣券(全场)  DISCOUNT_SINGLE, // 折扣券(单品)  CASH_ALL, // 代金券(全场)  CASH_SINGLE, // 代金券(单品)    // 以下券全部是单品券  EXCHANGE, // 兑换券(直接兑换，加钱兑换)  EXCHANGE_BUY, // 换购券  REDUCE_TO, // 减至券  BUY_SEND_SAME, // 买就送券(买a送a)  BUY_SEND_OTHER; // 买就送券(买a送b)
        /// </summary>
        [JsonProperty("voucher_type")]
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }
    }
}
