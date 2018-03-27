using Newtonsoft.Json;

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
        [JsonProperty("score")]
        public long Score { get; set; }

        /// <summary>
        /// 子评分项名
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
