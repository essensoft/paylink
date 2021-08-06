using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CampVoucherInfo Data Structure.
    /// </summary>
    public class CampVoucherInfo : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [JsonPropertyName("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 券优惠金额，单位元
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 品牌logo
        /// </summary>
        [JsonPropertyName("brand_logo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 封顶金额，单位元
        /// </summary>
        [JsonPropertyName("ceiling_amount")]
        public string CeilingAmount { get; set; }

        /// <summary>
        /// 券折扣
        /// </summary>
        [JsonPropertyName("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 券优惠类型
        /// </summary>
        [JsonPropertyName("discount_calc_type")]
        public string DiscountCalcType { get; set; }

        /// <summary>
        /// 门槛金额，单位元
        /// </summary>
        [JsonPropertyName("floor_amount")]
        public string FloorAmount { get; set; }

        /// <summary>
        /// 本次可以使用改券的商品条码
        /// </summary>
        [JsonPropertyName("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 活动状态 INIT("INIT", "已创建"),     P_AUDIT("P_AUDIT", "已提交审核"),     AUDIT("AUDIT", "已审核"),     WAIT_ACTIVE("WAIT_ACTIVE","提交激活"),     ACTIVE("ACTIVE", "已发布"),     PAUSE("PAUSE", "已暂停"),     FINISHED("FINISHED", "已结束"),     DISCARD("DISCARD", "已废弃"),
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 券模版id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 券描述
        /// </summary>
        [JsonPropertyName("voucher_description")]
        public string VoucherDescription { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [JsonPropertyName("voucher_name")]
        public string VoucherName { get; set; }
    }
}
