using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TopicItemVo Data Structure.
    /// </summary>
    public class TopicItemVo : AlipayObject
    {
        /// <summary>
        /// 话题描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 话题ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 0 正常状态，可使用;   -1 下线，不可使用。
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 话题标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
