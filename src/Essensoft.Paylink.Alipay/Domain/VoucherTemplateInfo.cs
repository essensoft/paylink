using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// VoucherTemplateInfo Data Structure.
    /// </summary>
    public class VoucherTemplateInfo : AlipayObject
    {
        /// <summary>
        /// 面额。每张代金券可以抵扣的金额。币种为人民币，单位为元。该数值不小于0，小数点以后最多两位
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 优惠封顶金额
        /// </summary>
        [JsonPropertyName("ceiling_amount")]
        public string CeilingAmount { get; set; }

        /// <summary>
        /// 券不可用时间详细规则
        /// </summary>
        [JsonPropertyName("disable_detail_periods")]
        public List<TimePeriodRule> DisableDetailPeriods { get; set; }

        /// <summary>
        /// 单品价格可以享受的折扣力度（如填写0.9就表示9折）。 该值大于等于0.1且小于1，小数点以后最多保留两位。
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
        /// 单品id列表, 单品券场景返回该字段
        /// </summary>
        [JsonPropertyName("goods_id")]
        public List<string> GoodsId { get; set; }

        /// <summary>
        /// 券模板ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

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
        /// 时间类型 RELATIVE: 相对类型 RELATIVE_BY_DAY: 相对类型按天取整 ABSOLUTE:绝对类型
        /// </summary>
        [JsonPropertyName("usable_time_type")]
        public string UsableTimeType { get; set; }

        /// <summary>
        /// 券使用说明
        /// </summary>
        [JsonPropertyName("voucher_description")]
        public string VoucherDescription { get; set; }

        /// <summary>
        /// 优惠券名称
        /// </summary>
        [JsonPropertyName("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 拟发行券的数量。单位为张。该数值是大于0的整数。
        /// </summary>
        [JsonPropertyName("voucher_quantity")]
        public string VoucherQuantity { get; set; }

        /// <summary>
        /// 券类型; GLOBAL_MONEY_OFF_VOUCHER: 全场代金券, GLOBAL_DISCOUNT_VOUCHER: 全场折扣券, ITEM_MONEY_OFF_VOUCHER:单品代金券, ITEM_DISCOUNT_VOUCHER:单品折扣券
        /// </summary>
        [JsonPropertyName("voucher_type")]
        public string VoucherType { get; set; }
    }
}
