using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditPayTermVO Data Structure.
    /// </summary>
    public class CreditPayTermVO : AlipayObject
    {
        /// <summary>
        /// 期限结束日期
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 期数
        /// </summary>
        [JsonPropertyName("term")]
        public long Term { get; set; }

        /// <summary>
        /// 期限单位
        /// </summary>
        [JsonPropertyName("term_unit")]
        public string TermUnit { get; set; }
    }
}
