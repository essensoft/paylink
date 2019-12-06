using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DateAreaModel Data Structure.
    /// </summary>
    public class DateAreaModel : AlipayObject
    {
        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonPropertyName("begin_date")]
        public string BeginDate { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }
    }
}
