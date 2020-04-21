using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EduAgeDemand Data Structure.
    /// </summary>
    public class EduAgeDemand : AlipayObject
    {
        /// <summary>
        /// 结束年龄
        /// </summary>
        [JsonPropertyName("age_end")]
        public string AgeEnd { get; set; }

        /// <summary>
        /// 开始年龄
        /// </summary>
        [JsonPropertyName("age_start")]
        public string AgeStart { get; set; }
    }
}
