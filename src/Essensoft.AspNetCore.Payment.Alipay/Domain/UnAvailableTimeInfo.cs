using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UnAvailableTimeInfo Data Structure.
    /// </summary>
    public class UnAvailableTimeInfo : AlipayObject
    {
        /// <summary>
        /// 起始时间
        /// </summary>
        [JsonPropertyName("from_date")]
        public string FromDate { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonPropertyName("to_date")]
        public string ToDate { get; set; }
    }
}
