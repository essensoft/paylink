using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LiabilityQuoteInfo Data Structure.
    /// </summary>
    public class LiabilityQuoteInfo : AlipayObject
    {
        /// <summary>
        /// 保司返回的起保时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("effect_end_time")]
        public string EffectEndTime { get; set; }

        /// <summary>
        /// 保司返回的起保时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("effect_start_time")]
        public string EffectStartTime { get; set; }

        /// <summary>
        /// 不计免赔保费，单位分
        /// </summary>
        [JsonPropertyName("iop_premium")]
        public string IopPremium { get; set; }

        /// <summary>
        /// 责任编码
        /// </summary>
        [JsonPropertyName("liability_no")]
        public string LiabilityNo { get; set; }

        /// <summary>
        /// 责任保费，单位分
        /// </summary>
        [JsonPropertyName("liability_premium")]
        public string LiabilityPremium { get; set; }

        /// <summary>
        /// 责任保额，单位分
        /// </summary>
        [JsonPropertyName("sum_insured")]
        public string SumInsured { get; set; }
    }
}
