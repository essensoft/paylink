using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// NewsfeedMediaLinkInfo Data Structure.
    /// </summary>
    public class NewsfeedMediaLinkInfo : AlipayObject
    {
        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonPropertyName("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 资源的来源
        /// </summary>
        [JsonPropertyName("content_source")]
        public string ContentSource { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonPropertyName("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 链接的缩略图
        /// </summary>
        [JsonPropertyName("thumb")]
        public string Thumb { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// linkurl
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
