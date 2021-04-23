using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// VoucherConsultInfo Data Structure.
    /// </summary>
    public class VoucherConsultInfo : AlipayObject
    {
        /// <summary>
        /// 封顶优惠金额，单位为元
        /// </summary>
        [JsonPropertyName("ceiling_amount")]
        public string CeilingAmount { get; set; }

        /// <summary>
        /// 单品券商品优惠信息，仅针对单品券
        /// </summary>
        [JsonPropertyName("item_promo_info")]
        public ItemPromoInfo ItemPromoInfo { get; set; }

        /// <summary>
        /// 是否为可使用的互斥券中最优的（目前返回的记录该值均为true，即可忽略该值判断）
        /// </summary>
        [JsonPropertyName("optimal")]
        public bool Optimal { get; set; }

        /// <summary>
        /// 优惠总金额，单位为元
        /// </summary>
        [JsonPropertyName("promo_amount")]
        public string PromoAmount { get; set; }

        /// <summary>
        /// 优惠文案
        /// </summary>
        [JsonPropertyName("promo_text")]
        public string PromoText { get; set; }

        /// <summary>
        /// 优惠类型： 代金(FIX),折扣(DISCOUNT),减至(SPECIAL，即特价券)
        /// </summary>
        [JsonPropertyName("promo_type")]
        public string PromoType { get; set; }

        /// <summary>
        /// 满减金额，单位为元，仅针对代金券
        /// </summary>
        [JsonPropertyName("reduction_amount")]
        public string ReductionAmount { get; set; }

        /// <summary>
        /// 优惠额度，如3折券，返回0.7，仅针对折扣券
        /// </summary>
        [JsonPropertyName("reduction_ratio")]
        public string ReductionRatio { get; set; }

        /// <summary>
        /// 减至金额，单位为元，仅针对减至券
        /// </summary>
        [JsonPropertyName("specified_amount")]
        public string SpecifiedAmount { get; set; }

        /// <summary>
        /// 优惠门槛，单位为元
        /// </summary>
        [JsonPropertyName("threshold_amount")]
        public string ThresholdAmount { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [JsonPropertyName("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 券类型： 1）全场券(ALL) 2）单品券(ITEM)
        /// </summary>
        [JsonPropertyName("voucher_type")]
        public string VoucherType { get; set; }
    }
}
