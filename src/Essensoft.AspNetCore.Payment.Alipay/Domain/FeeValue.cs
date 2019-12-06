using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FeeValue Data Structure.
    /// </summary>
    public class FeeValue : AlipayObject
    {
        /// <summary>
        /// 保底费率
        /// </summary>
        [JsonPropertyName("bottom_cent")]
        public string BottomCent { get; set; }

        /// <summary>
        /// 币种（如人民币是156）
        /// </summary>
        [JsonPropertyName("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 固定费额
        /// </summary>
        [JsonPropertyName("fix_cent")]
        public string FixCent { get; set; }

        /// <summary>
        /// 最小费率
        /// </summary>
        [JsonPropertyName("lower")]
        public string Lower { get; set; }

        /// <summary>
        /// 费率比例单位。  ONE("RO", "ONE", "一", "一"),  ONE_HUNDREDTH("RP", "ONE_HUNDREDTH", "百分之一", "百分之一"),  ONE_THOUSANDTH("RM", "ONE_THOUSANDTH", "千分之一", "千分之一"),  ONE_TEN_THOUSANDTH("RT", "ONE_TEN_THOUSANDTH", "万分之一", "万分之一");
        /// </summary>
        [JsonPropertyName("rate_unit")]
        public string RateUnit { get; set; }

        /// <summary>
        /// 费率值
        /// </summary>
        [JsonPropertyName("rate_value")]
        public string RateValue { get; set; }

        /// <summary>
        /// 封顶费额
        /// </summary>
        [JsonPropertyName("top_cent")]
        public string TopCent { get; set; }

        /// <summary>
        /// 最大费率
        /// </summary>
        [JsonPropertyName("upper")]
        public string Upper { get; set; }
    }
}
