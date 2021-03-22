using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ArticleAttachmentInfo Data Structure.
    /// </summary>
    public class ArticleAttachmentInfo : AlipayObject
    {
        /// <summary>
        /// 文章附件
        /// </summary>
        [JsonPropertyName("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 附件完整Key
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 附件的url
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
