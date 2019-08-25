using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseContentlibStandardcontentSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseContentlibStandardcontentSendModel : AlipayObject
    {
        /// <summary>
        /// action_type为此次请求类型，值为枚举，有三种，publish(发布),depublish(撤回),heartbeat(心跳),具体对接请联系负责人,必填
        /// </summary>
        [JsonProperty("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// extInfo为扩展信息，json格式
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// public_id为来源文章需要接入的内容号,当为多号接入时，必填
        /// </summary>
        [JsonProperty("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// source_author是来源文章的作者，当action_type为publish时，非必填
        /// </summary>
        [JsonProperty("source_author")]
        public string SourceAuthor { get; set; }

        /// <summary>
        /// source_category是来源文章的类别，如有多个，请用英文逗号隔开，如示例值所示，非必填
        /// </summary>
        [JsonProperty("source_category")]
        public string SourceCategory { get; set; }

        /// <summary>
        /// source_content为来源文章的正文内容，当action_type为publish的时候，必填
        /// </summary>
        [JsonProperty("source_content")]
        public string SourceContent { get; set; }

        /// <summary>
        /// source_cover值为图片链接，用于主页的封面图显示，图片尺寸900*500。无封面图情况需产品确认。选填
        /// </summary>
        [JsonProperty("source_cover")]
        public string SourceCover { get; set; }

        /// <summary>
        /// source_id是来源方能唯一标识一篇文章的id,当action_type为publish及depublish时，必填
        /// </summary>
        [JsonProperty("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// source_keywords为来源文章的关键字，字符串类型，多个关键字用英文逗号隔开，如示例值所示。非必填
        /// </summary>
        [JsonProperty("source_keywords")]
        public string SourceKeywords { get; set; }

        /// <summary>
        /// source_link为来源文章的原始链接地址，非必填
        /// </summary>
        [JsonProperty("source_link")]
        public string SourceLink { get; set; }

        /// <summary>
        /// 来源文章的发布时间，当action_type为publish的时候，必填
        /// </summary>
        [JsonProperty("source_publish_date")]
        public string SourcePublishDate { get; set; }

        /// <summary>
        /// source_summary为来源文章的摘要，非必填
        /// </summary>
        [JsonProperty("source_summary")]
        public string SourceSummary { get; set; }

        /// <summary>
        /// source_thumbnail_type是文章列表展示时的配图类型。有大图，三图，左文右图，无图四种。取值为枚举，oneBig(大图)，three(三图)，right(左文右图)，noImage(无图),具体显示样式请联系负责人
        /// </summary>
        [JsonProperty("source_thumbnail_type")]
        public string SourceThumbnailType { get; set; }

        /// <summary>
        /// source_thumbnails为文章列表显示时的配图。非必填，可由内容中台的算法计算。如果填入，则填图片链接，如有多个，请用英文逗号隔开，如示例值所示，具体接入请联系负责人
        /// </summary>
        [JsonProperty("source_thumbnails")]
        public string SourceThumbnails { get; set; }

        /// <summary>
        /// source_title是来源方文章标题，当action_type是publish时，必填
        /// </summary>
        [JsonProperty("source_title")]
        public string SourceTitle { get; set; }
    }
}
