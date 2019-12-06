using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CraftsmanSubAssessment Data Structure.
    /// </summary>
    public class CraftsmanSubAssessment : AlipayObject
    {
        /// <summary>
        /// 子评分
        /// </summary>
        [JsonPropertyName("score")]
        public long Score { get; set; }

        /// <summary>
        /// 子评分项名
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
