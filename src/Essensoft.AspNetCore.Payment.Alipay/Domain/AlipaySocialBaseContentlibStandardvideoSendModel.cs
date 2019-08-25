using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseContentlibStandardvideoSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseContentlibStandardvideoSendModel : AlipayObject
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
        /// source_author是来源内容的作者，当action_type为publish时，非必填
        /// </summary>
        [JsonProperty("source_author")]
        public string SourceAuthor { get; set; }

        /// <summary>
        /// source_keywords为来源内容的关键字，字符串类型，多个关键字用英文逗号隔开，如示例值所示。非必填
        /// </summary>
        [JsonProperty("source_category")]
        public string SourceCategory { get; set; }

        /// <summary>
        /// source_cover值为图片链接，用于主页的封面图显示，图片尺寸900*500。无封面图情况需产品确认。当action_type为publish的时候，必填
        /// </summary>
        [JsonProperty("source_cover")]
        public string SourceCover { get; set; }

        /// <summary>
        /// source_id是来源方能唯一确定一份内容的id,当action_type为publish及depublish时，必填
        /// </summary>
        [JsonProperty("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 来源文章的发布时间，当action_type为publish的时候，必填
        /// </summary>
        [JsonProperty("source_publish_date")]
        public string SourcePublishDate { get; set; }

        /// <summary>
        /// source_summary为来源内容的摘要，非必填
        /// </summary>
        [JsonProperty("source_summary")]
        public string SourceSummary { get; set; }

        /// <summary>
        /// source_title是来源方内容标题，当action_type是publish时，必填
        /// </summary>
        [JsonProperty("source_title")]
        public string SourceTitle { get; set; }

        /// <summary>
        /// 视频Id,当action_type为publish的时候，必填
        /// </summary>
        [JsonProperty("video_id")]
        public string VideoId { get; set; }

        /// <summary>
        /// 视频时长
        /// </summary>
        [JsonProperty("video_length")]
        public string VideoLength { get; set; }

        /// <summary>
        /// 视频发布器，如一财后台，创作者后台
        /// </summary>
        [JsonProperty("video_publish_type")]
        public string VideoPublishType { get; set; }

        /// <summary>
        /// 视频大小
        /// </summary>
        [JsonProperty("video_size")]
        public string VideoSize { get; set; }

        /// <summary>
        /// 视频来源方运营标签，英文逗号隔开
        /// </summary>
        [JsonProperty("video_tags")]
        public string VideoTags { get; set; }

        /// <summary>
        /// 视频url，当action_type为publish的时候，必填
        /// </summary>
        [JsonProperty("video_url")]
        public string VideoUrl { get; set; }
    }
}
