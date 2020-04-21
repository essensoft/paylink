using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VoucherRec Data Structure.
    /// </summary>
    public class VoucherRec : AlipayObject
    {
        /// <summary>
        /// 总收藏量
        /// </summary>
        [JsonPropertyName("all_keep_count")]
        public string AllKeepCount { get; set; }

        /// <summary>
        /// 判断券的类型
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 头图
        /// </summary>
        [JsonPropertyName("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// 人群
        /// </summary>
        [JsonPropertyName("crowds")]
        public string Crowds { get; set; }

        /// <summary>
        /// 折扣券的折扣力度
        /// </summary>
        [JsonPropertyName("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 是否有面向人群
        /// </summary>
        [JsonPropertyName("has_crowd")]
        public string HasCrowd { get; set; }

        /// <summary>
        /// 是否自动领取券
        /// </summary>
        [JsonPropertyName("is_auto_obtain")]
        public string IsAutoObtain { get; set; }

        /// <summary>
        /// 是否是商圈发的券
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
        /// 券有效期开始时间
        /// </summary>
        [JsonPropertyName("item_gmt_start")]
        public string ItemGmtStart { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 总量
        /// </summary>
        [JsonPropertyName("item_quantity")]
        public string ItemQuantity { get; set; }

        /// <summary>
        /// 销售模式
        /// </summary>
        [JsonPropertyName("item_sales_mode")]
        public string ItemSalesMode { get; set; }

        /// <summary>
        /// 销量
        /// </summary>
        [JsonPropertyName("item_sold_quantity")]
        public string ItemSoldQuantity { get; set; }

        /// <summary>
        /// 原价
        /// </summary>
        [JsonPropertyName("original_amount")]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// 每满threshold_amount元减perValueAmount元，封顶valueAmount元
        /// </summary>
        [JsonPropertyName("per_value_amount")]
        public string PerValueAmount { get; set; }

        /// <summary>
        /// 泛行业商品详情图片
        /// </summary>
        [JsonPropertyName("picture_details")]
        public string PictureDetails { get; set; }

        /// <summary>
        /// 价格浮动模式
        /// </summary>
        [JsonPropertyName("price_mode")]
        public string PriceMode { get; set; }

        /// <summary>
        /// 券领取类型
        /// </summary>
        [JsonPropertyName("purchase_mode")]
        public string PurchaseMode { get; set; }

        /// <summary>
        /// 送单品名称
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
        /// 满N元可优惠
        /// </summary>
        [JsonPropertyName("threshold_amount")]
        public string ThresholdAmount { get; set; }

        /// <summary>
        /// 使用门槛
        /// </summary>
        [JsonPropertyName("use_condition_amount")]
        public string UseConditionAmount { get; set; }

        /// <summary>
        /// 券使用的有效时间
        /// </summary>
        [JsonPropertyName("valid_times")]
        public string ValidTimes { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [JsonPropertyName("value_amount")]
        public string ValueAmount { get; set; }

        /// <summary>
        /// 券的跳转地址
        /// </summary>
        [JsonPropertyName("voucher_detail_url")]
        public string VoucherDetailUrl { get; set; }

        /// <summary>
        /// 券地址
        /// </summary>
        [JsonPropertyName("voucher_logo_url")]
        public string VoucherLogoUrl { get; set; }

        /// <summary>
        /// DISCOUNT_ALL 折扣券(全场)   DISCOUNT_SINGLE 折扣券(单品)   CASH_ALL 代金券(全场)   CASH_SINGLE 金券(单品)      以下券全部是单品券：   EXCHANGE 兑换券(直接兑换, 加钱兑换) EXCHANGE_BUY 换购券   REDUCE_TO 减至券   BUY_SEND_SAME 买就送券(买a送a)   BUY_SEND_OTHER 买就送券(买a送b)
        /// </summary>
        [JsonPropertyName("voucher_type")]
        public string VoucherType { get; set; }
    }
}
