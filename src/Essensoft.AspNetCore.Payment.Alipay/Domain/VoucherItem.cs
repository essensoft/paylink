using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VoucherItem Data Structure.
    /// </summary>
    public class VoucherItem : AlipayObject
    {
        /// <summary>
        /// 过期时间，格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 满减类型：券面额  折扣类型：折扣；单次封顶优惠金额  减至：减至金额
        /// </summary>
        [JsonPropertyName("promo_info")]
        public PromoInfo PromoInfo { get; set; }

        /// <summary>
        /// 优惠类型，共三种。 代金(FIX),折扣(DISCOUNT),减至(SPECIAL)
        /// </summary>
        [JsonPropertyName("promo_type")]
        public string PromoType { get; set; }

        /// <summary>
        /// 发券时间，格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// 券模板id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 消费门槛
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
        /// 券状态，共三种。 可用(ENABLED),不可用(DISABLED),删除(DELETE)
        /// </summary>
        [JsonPropertyName("voucher_status")]
        public string VoucherStatus { get; set; }

        /// <summary>
        /// 优惠归属为商家优惠时，优惠类型包括：商家全场券（ALIPAY_BIZ_VOUCHER）、单品优惠券(ALIPAY_COMMON_ITEM_VOUCHER)
        /// </summary>
        [JsonPropertyName("voucher_type")]
        public string VoucherType { get; set; }
    }
}
