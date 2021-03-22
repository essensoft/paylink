using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// PosDiscountDetail Data Structure.
    /// </summary>
    public class PosDiscountDetail : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动类型，可枚举的类型 (1)itemDiscount: 商品级优惠 (2) buyItem：购买商品 (3) fullDiscountCamp：全场折活动 (4) fullCutCamp：全场满减活动 (5) fullCutVoucher 全场满减券 (6) itemReductionVoucher：单品立减券 (7) itemDiscountVoucher：单品折扣券 (8) itemSpecifiedVoucher：单品减至券 (9) userPoint : 积分抵扣 (10) comboDiscount  :商品组合折扣 (11) comboSpecified : 商品组合一口价 (12) alipayBSiteVoucher:支付宝B站劵
        /// </summary>
        [JsonPropertyName("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 优惠名称
        /// </summary>
        [JsonPropertyName("discount_name")]
        public string DiscountName { get; set; }

        /// <summary>
        /// 优惠类型
        /// </summary>
        [JsonPropertyName("discount_type")]
        public string DiscountType { get; set; }

        /// <summary>
        /// 菜品id
        /// </summary>
        [JsonPropertyName("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 关联的主菜在这笔推单里的菜品流水id
        /// </summary>
        [JsonPropertyName("dish_main_out_detail_no")]
        public string DishMainOutDetailNo { get; set; }

        /// <summary>
        /// 菜品的在这笔推单里的流水明细id
        /// </summary>
        [JsonPropertyName("dish_out_detail_no")]
        public string DishOutDetailNo { get; set; }

        /// <summary>
        /// 菜品skuId
        /// </summary>
        [JsonPropertyName("dish_sku_id")]
        public string DishSkuId { get; set; }

        /// <summary>
        /// 此字段废弃，请使用ext_info_str。（扩展信息，存储优惠的详细模型。json对象格式，key和value都为字符串，其中DISH_ID为菜品id，USER_ITEM_ID为被核销商品id）
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 扩展信息，存储优惠的详细模型。json对象格式，key和value都为字符串，其中DISH_ID为菜品id，USER_ITEM_ID为被核销商品id，TEMPLATE_ID为券模版id，VOUCHER_ID为券实例id,POS_KEY为星巴克的poskey, DEDUCT_POINT为星巴克星星数.IS_CHANGE为星巴克是否置换标 ,"deductDetails":"[{\"consumeUnitPoint\":9,\"preferentialNum\":2,\"unitPrice\":"25.00"},{\"consumeUnitPoint\":1,\"preferentialNum\":1,\"unitPrice\":"3.00"}]"
        /// </summary>
        [JsonPropertyName("ext_info_str")]
        public string ExtInfoStr { get; set; }

        /// <summary>
        /// 商家出资优惠金额，以元为单位，精确到分; 如果是星巴克的星星，这里表示星星抵扣金额
        /// </summary>
        [JsonPropertyName("mrt_discount")]
        public string MrtDiscount { get; set; }

        /// <summary>
        /// 平台出资优惠金额，以元为单位，精确到分
        /// </summary>
        [JsonPropertyName("rt_discount")]
        public string RtDiscount { get; set; }

        /// <summary>
        /// 人群要求(会员)，可枚举的类型(1)member 会员(2) normal 普通
        /// </summary>
        [JsonPropertyName("target_user_type")]
        public string TargetUserType { get; set; }

        /// <summary>
        /// 被核销的商品id
        /// </summary>
        [JsonPropertyName("used_item_id")]
        public string UsedItemId { get; set; }
    }
}
