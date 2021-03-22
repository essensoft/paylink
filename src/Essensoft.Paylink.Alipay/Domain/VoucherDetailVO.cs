using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// VoucherDetailVO Data Structure.
    /// </summary>
    public class VoucherDetailVO : AlipayObject
    {
        /// <summary>
        /// 优惠金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 活动发起方LOGO
        /// </summary>
        [JsonPropertyName("brand_logo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 活动发起方名称
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 优惠封顶金额
        /// </summary>
        [JsonPropertyName("ceiling_amount")]
        public string CeilingAmount { get; set; }

        /// <summary>
        /// 券不可用时间详细规
        /// </summary>
        [JsonPropertyName("disable_detail_period")]
        public List<TimePeriodRule> DisableDetailPeriod { get; set; }

        /// <summary>
        /// 优惠折扣比例
        /// </summary>
        [JsonPropertyName("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 券优惠类型; DISCOUNT: 折扣 FIX: 代金
        /// </summary>
        [JsonPropertyName("discount_calc_type")]
        public string DiscountCalcType { get; set; }

        /// <summary>
        /// 门槛金额
        /// </summary>
        [JsonPropertyName("floor_amount")]
        public string FloorAmount { get; set; }

        /// <summary>
        /// 单品券场景下, 单品券能够核销的货品ID列表
        /// </summary>
        [JsonPropertyName("goods_id")]
        public List<string> GoodsId { get; set; }

        /// <summary>
        /// 券的领取时间
        /// </summary>
        [JsonPropertyName("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// 券状态; ENABLED: 可用, DISABLED: 不可用, EXPIRED: 已过期
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 券使用时间详细规则
        /// </summary>
        [JsonPropertyName("usable_detail_period")]
        public List<TimePeriodRule> UsableDetailPeriod { get; set; }

        /// <summary>
        /// 券生效结束时间
        /// </summary>
        [JsonPropertyName("usable_end_time")]
        public string UsableEndTime { get; set; }

        /// <summary>
        /// 券生效开始时间
        /// </summary>
        [JsonPropertyName("usable_start_time")]
        public string UsableStartTime { get; set; }

        /// <summary>
        /// 券使用说明
        /// </summary>
        [JsonPropertyName("voucher_description")]
        public string VoucherDescription { get; set; }

        /// <summary>
        /// 券ID
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [JsonPropertyName("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 券类型;  GLOBAL_MONEY_OFF_VOUCHER: 全场代金券,  GLOBAL_DISCOUNT_VOUCHER: 全场折扣券, ITEM_MONEY_OFF_VOUCHER:单品代金券, ITEM_DISCOUNT_VOUCHER:单品折扣券
        /// </summary>
        [JsonPropertyName("voucher_type")]
        public string VoucherType { get; set; }
    }
}
