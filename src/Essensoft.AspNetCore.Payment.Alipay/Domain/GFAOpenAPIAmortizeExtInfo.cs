using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GFAOpenAPIAmortizeExtInfo Data Structure.
    /// </summary>
    public class GFAOpenAPIAmortizeExtInfo : AlipayObject
    {
        /// <summary>
        /// 待摊销金额。（单位：各币种的“元”单位，精确到小数点后两位）
        /// </summary>
        [JsonPropertyName("amortize_amount")]
        public string AmortizeAmount { get; set; }

        /// <summary>
        /// 摊销频率
        /// </summary>
        [JsonPropertyName("amortize_period_type")]
        public string AmortizePeriodType { get; set; }

        /// <summary>
        /// 摊销类型
        /// </summary>
        [JsonPropertyName("amortize_type")]
        public string AmortizeType { get; set; }

        /// <summary>
        /// 待摊销业务量
        /// </summary>
        [JsonPropertyName("amortize_volume")]
        public long AmortizeVolume { get; set; }

        /// <summary>
        /// 摊销失效时间。（GMT+8时区，精确到天，暂不支持小时分秒等粒度）
        /// </summary>
        [JsonPropertyName("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 摊销生效时间。（GMT+8时区，精确到天，暂不支持小时分秒等粒度）
        /// </summary>
        [JsonPropertyName("gmt_valid")]
        public string GmtValid { get; set; }

        /// <summary>
        /// 同 out_business_no 下业财已受理的总摊销金额（单位：各币种的“元”单位，精确到小数点后两位）
        /// </summary>
        [JsonPropertyName("total_amortize_amount")]
        public string TotalAmortizeAmount { get; set; }
    }
}
