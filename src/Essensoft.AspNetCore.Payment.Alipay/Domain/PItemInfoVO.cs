using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PItemInfoVO Data Structure.
    /// </summary>
    public class PItemInfoVO : AlipayObject
    {
        /// <summary>
        /// 唯一code
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 链接
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
