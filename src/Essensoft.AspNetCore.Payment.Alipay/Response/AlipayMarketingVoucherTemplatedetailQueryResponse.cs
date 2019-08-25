using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingVoucherTemplatedetailQueryResponse.
    /// </summary>
    public class AlipayMarketingVoucherTemplatedetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 面额。每张代金券可以抵扣的金额。币种为人民币，单位为元。该数值不小于0，小数点以后最多两位。当券类型为无资金单品券（ITEM_CASHLESS_FIX_VOUCHER、ITEM_CASHLESS_DISCOUNT_VOUCHER、ITEM_CASHLESS_SPE_VOUCHER）时，暂不支持查询本参数，出参为0
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 最低额度。券的最低使用门槛金额，只有订单金额大于等于最低额度时券才能使用。币种为人民币，单位为元。该数值不小于0，小数点以后最多保留两位。
        /// </summary>
        [JsonProperty("floor_amount")]
        public string FloorAmount { get; set; }

        /// <summary>
        /// 已发放总金额。币种为人民币，单位为元。该数值不小于0，小数点以后最多两位。
        /// </summary>
        [JsonProperty("publish_amount")]
        public string PublishAmount { get; set; }

        /// <summary>
        /// 已发放张数。单位为张。该数值是大于0的整数。
        /// </summary>
        [JsonProperty("publish_count")]
        public long PublishCount { get; set; }

        /// <summary>
        /// 发放结束时间，格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 发放开始时间，格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("publish_start_time")]
        public string PublishStartTime { get; set; }

        /// <summary>
        /// 退回金额。币种为人民币，单位为元。该数值不小于0，小数点以后最多两位。
        /// </summary>
        [JsonProperty("recycle_amount")]
        public string RecycleAmount { get; set; }

        /// <summary>
        /// 模板状态，可枚举。分别为‘草稿’(I)、‘生效’(S)、‘删除’(D)和‘过期’(E)
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 券模板ID
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 总金额面额。币种为人民币，单位为元。该数值不小于0，小数点以后最多两位。仅代金券有效。当券类型为无资金单品券（ITEM_CASHLESS_FIX_VOUCHER、ITEM_CASHLESS_DISCOUNT_VOUCHER、ITEM_CASHLESS_SPE_VOUCHER）时，暂不支持查询本参数，出参为0
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 已使用总金额。币种为人民币，单位为元。该数值不小于0，小数点以后最多两位。
        /// </summary>
        [JsonProperty("used_amount")]
        public string UsedAmount { get; set; }

        /// <summary>
        /// 已使用张数。单位为张。该数值是大于0的整数。
        /// </summary>
        [JsonProperty("used_count")]
        public long UsedCount { get; set; }

        /// <summary>
        /// 券使用说明
        /// </summary>
        [JsonProperty("voucher_description")]
        public string VoucherDescription { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [JsonProperty("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 拟发行券的数量。单位为张。该数值是大于0的整数。
        /// </summary>
        [JsonProperty("voucher_quantity")]
        public long VoucherQuantity { get; set; }

        /// <summary>
        /// 券类型。可枚举，暂时只支持代金券(FIX_VOUCHER)、无资金单品代金券（ITEM_CASHLESS_FIX_VOUCHER）、无资金单品折扣券（ITEM_CASHLESS_DISCOUNT_VOUCHER）、无资金单品特价券（ITEM_CASHLESS_SPE_VOUCHER）
        /// </summary>
        [JsonProperty("voucher_type")]
        public string VoucherType { get; set; }

        /// <summary>
        /// 券有效期。有两种类型：绝对时间和相对时间。使用JSON字符串表示。绝对时间有3个key：type、start、end，type取值固定为"ABSOLUTE"，start和end分别表示券生效时间和失效时间，格式为yyyy-MM-dd HH:mm:ss。绝对时间示例：{"type": "ABSOLUTE", "start": "2017-01-10 00:00:00", "end": "2017-01-13 23:59:59"}。相对时间有3个key：type、duration、unit，type取值固定为"RELATIVE"，duration表示从发券时间开始到往后推duration个单位时间为止作为券的使用有效期，unit表示有效时间单位，有效时间单位可枚举：MINUTE, HOUR, DAY。示例：{"type": "RELATIVE", "duration": 1 , "unit": "DAY" }，如果此刻发券，那么该券从现在开始生效1(duration)天(unit)后失效。
        /// </summary>
        [JsonProperty("voucher_valid_period")]
        public string VoucherValidPeriod { get; set; }
    }
}
