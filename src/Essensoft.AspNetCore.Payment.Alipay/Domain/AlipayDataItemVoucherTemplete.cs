using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataItemVoucherTemplete Data Structure.
    /// </summary>
    public class AlipayDataItemVoucherTemplete : AlipayObject
    {
        /// <summary>
        /// 延迟生效时间（手动领取条件下，可跟valid_period组合使用）
        /// </summary>
        [JsonPropertyName("delay_minute")]
        public long DelayMinute { get; set; }

        /// <summary>
        /// 券使用规则描述，包括描述标题及描述内容列表
        /// </summary>
        [JsonPropertyName("desc_details")]
        public List<AlipayDataItemDescription> DescDetails { get; set; }

        /// <summary>
        /// 折扣率，填写0~1间的小数且不包括0和1，如八折则传入0.8
        /// </summary>
        [JsonPropertyName("discount_rate")]
        public string DiscountRate { get; set; }

        /// <summary>
        /// 外部单品列表
        /// </summary>
        [JsonPropertyName("external_goods_list")]
        public AlipayDataItemGoodsList ExternalGoodsList { get; set; }

        /// <summary>
        /// 使用时间规则，控制商品的生效时间
        /// </summary>
        [JsonPropertyName("limit_period_info_list")]
        public AlipayDataItemLimitPeriodInfo LimitPeriodInfoList { get; set; }

        /// <summary>
        /// 商品原金额，只有单品代金券有，丽人行业需要填写此字段
        /// </summary>
        [JsonPropertyName("original_amount")]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// 券原折扣
        /// </summary>
        [JsonPropertyName("original_rate")]
        public string OriginalRate { get; set; }

        /// <summary>
        /// 单品代金券中的减至金额
        /// </summary>
        [JsonPropertyName("reduce_to_amount")]
        public string ReduceToAmount { get; set; }

        /// <summary>
        /// 折扣金额取整规则 AUTO_ROUNDING_YUAN：自动抹零到元 AUTO_ROUNDING_JIAO：自动抹零到角 ROUNDING_UP_YUAN：四舍五入到元 ROUNDING_UP_JIAO：四舍五入到角
        /// </summary>
        [JsonPropertyName("rounding_rule")]
        public string RoundingRule { get; set; }

        /// <summary>
        /// 起步数量，用于指定可享受优惠的起步单品购买数量
        /// </summary>
        [JsonPropertyName("threshold_amount")]
        public string ThresholdAmount { get; set; }

        /// <summary>
        /// 起步数量，用于指定可享受优惠的起步单品购买数量
        /// </summary>
        [JsonPropertyName("threshold_quantity")]
        public string ThresholdQuantity { get; set; }

        /// <summary>
        /// 领券之后多长时间内可以核销，单位：分钟，传入数值需大于1440（一天）
        /// </summary>
        [JsonPropertyName("valid_period")]
        public long ValidPeriod { get; set; }

        /// <summary>
        /// 价值金额  CASH类型为代金券金额  DISCOUNT类型为优惠封顶金额
        /// </summary>
        [JsonPropertyName("value_amount")]
        public string ValueAmount { get; set; }

        /// <summary>
        /// 券的描述信息，目前客户端将统一展示“折扣须知”
        /// </summary>
        [JsonPropertyName("voucher_desc")]
        public string VoucherDesc { get; set; }

        /// <summary>
        /// 券类型：单品代金券为CASH类型，全场折扣券为DISCOUNT类型
        /// </summary>
        [JsonPropertyName("voucher_type")]
        public string VoucherType { get; set; }
    }
}
