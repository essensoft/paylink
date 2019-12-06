using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PromoVoucherInfo Data Structure.
    /// </summary>
    public class PromoVoucherInfo : AlipayObject
    {
        /// <summary>
        /// 折扣（折扣券类型才有）
        /// </summary>
        [JsonPropertyName("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 是否是自动领取券
        /// </summary>
        [JsonPropertyName("is_auto_obtain")]
        public string IsAutoObtain { get; set; }

        /// <summary>
        /// 是否是商圈发的券 true/false
        /// </summary>
        [JsonPropertyName("is_mall_voucher")]
        public string IsMallVoucher { get; set; }

        /// <summary>
        /// 券品牌名称
        /// </summary>
        [JsonPropertyName("item_brand_name")]
        public string ItemBrandName { get; set; }

        /// <summary>
        /// 券有效期结束时间
        /// </summary>
        [JsonPropertyName("item_gmt_end")]
        public string ItemGmtEnd { get; set; }

        /// <summary>
        /// 商品有效期开始时间
        /// </summary>
        [JsonPropertyName("item_gmt_start")]
        public string ItemGmtStart { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 券图片地址
        /// </summary>
        [JsonPropertyName("item_logo")]
        public string ItemLogo { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 买a送b 送单品名称
        /// </summary>
        [JsonPropertyName("send_item_name")]
        public string SendItemName { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 券使用门槛金额(元)
        /// </summary>
        [JsonPropertyName("use_condition_amount")]
        public string UseConditionAmount { get; set; }

        /// <summary>
        /// 代金券 减至券 兑换券 换购券 金额
        /// </summary>
        [JsonPropertyName("value_amount")]
        public string ValueAmount { get; set; }

        /// <summary>
        /// 券跳转地址(h5)
        /// </summary>
        [JsonPropertyName("voucher_detail_url")]
        public string VoucherDetailUrl { get; set; }

        /// <summary>
        /// DISCOUNT_ALL, // 折扣券(全场)  DISCOUNT_SINGLE, // 折扣券(单品)  CASH_ALL, // 代金券(全场)  CASH_SINGLE, // 代金券(单品)    // 以下券全部是单品券  EXCHANGE, // 兑换券(直接兑换，加钱兑换)  EXCHANGE_BUY, // 换购券  REDUCE_TO, // 减至券  BUY_SEND_SAME, // 买就送券(买a送a)  BUY_SEND_OTHER; // 买就送券(买a送b)
        /// </summary>
        [JsonPropertyName("voucher_type")]
        public string VoucherType { get; set; }
    }
}
