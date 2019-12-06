using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseContentlibStandardvideoauditSendModel Data Structure.
    /// </summary>
    public class AlipaySocialBaseContentlibStandardvideoauditSendModel : AlipayObject
    {
        /// <summary>
        /// publish(审核通过),  depublish(审核不通过)
        /// </summary>
        [JsonPropertyName("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 扩展字段，传递非标准参数信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 驳回原因
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 操作日期
        /// </summary>
        [JsonPropertyName("source_publish_date")]
        public string SourcePublishDate { get; set; }

        /// <summary>
        /// 视频Id
        /// </summary>
        [JsonPropertyName("video_id")]
        public string VideoId { get; set; }

        /// <summary>
        /// 视频时长
        /// </summary>
        [JsonPropertyName("video_length")]
        public string VideoLength { get; set; }

        /// <summary>
        /// 视频来源
        /// </summary>
        [JsonPropertyName("video_publish_type")]
        public string VideoPublishType { get; set; }

        /// <summary>
        /// 视频的大小
        /// </summary>
        [JsonPropertyName("video_size")]
        public string VideoSize { get; set; }

        /// <summary>
        /// 视频的标签，以,隔开
        /// </summary>
        [JsonPropertyName("video_tags")]
        public string VideoTags { get; set; }

        /// <summary>
        /// video的url
        /// </summary>
        [JsonPropertyName("video_url")]
        public string VideoUrl { get; set; }
    }
}
