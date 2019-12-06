using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseContentlibNewsflashSendModel Data Structure.
    /// </summary>
    public class AlipaySocialBaseContentlibNewsflashSendModel : AlipayObject
    {
        /// <summary>
        /// 作者
        /// </summary>
        [JsonPropertyName("author")]
        public string Author { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 扩展信息，json格式数据
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 配图地址
        /// </summary>
        [JsonPropertyName("images")]
        public string Images { get; set; }

        /// <summary>
        /// 标签, 多个用逗号隔开
        /// </summary>
        [JsonPropertyName("opr_tags")]
        public string OprTags { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [JsonPropertyName("publish_date")]
        public string PublishDate { get; set; }

        /// <summary>
        /// 推荐权重，0：不可用，1：显示，2：加权
        /// </summary>
        [JsonPropertyName("recommend")]
        public long Recommend { get; set; }

        /// <summary>
        /// 来源渠道
        /// </summary>
        [JsonPropertyName("source_channel_key")]
        public string SourceChannelKey { get; set; }

        /// <summary>
        /// 快讯来源id
        /// </summary>
        [JsonPropertyName("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
