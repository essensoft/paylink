using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditPayDayRangePricingVO Data Structure.
    /// </summary>
    public class CreditPayDayRangePricingVO : AlipayObject
    {
        /// <summary>
        /// 按天定价结束时间
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 分段利率（小数形式，自行*100%转换为百分数形式）
        /// </summary>
        [JsonPropertyName("int_rate")]
        public string IntRate { get; set; }

        /// <summary>
        /// 分段利息，单位元
        /// </summary>
        [JsonPropertyName("interest")]
        public string Interest { get; set; }

        /// <summary>
        /// 按天定价开始时间
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }
    }
}
