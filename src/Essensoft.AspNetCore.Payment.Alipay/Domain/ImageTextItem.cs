using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ImageTextItem Data Structure.
    /// </summary>
    public class ImageTextItem : AlipayObject
    {
        /// <summary>
        /// 描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 封面图链接
        /// </summary>
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 文章内容id
        /// </summary>
        [JsonPropertyName("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
