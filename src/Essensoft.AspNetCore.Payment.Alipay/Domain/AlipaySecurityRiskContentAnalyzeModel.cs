using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskContentAnalyzeModel Data Structure.
    /// </summary>
    public class AlipaySecurityRiskContentAnalyzeModel : AlipayObject
    {
        /// <summary>
        /// 内容的发表账户号，用于将需要检测的内容（文本、链接、图片、音视频）等和账户进行关联
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 账户类型：    用户： 0  商户： 1
        /// </summary>
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 应用主场景
        /// </summary>
        [JsonPropertyName("app_main_scene")]
        public string AppMainScene { get; set; }

        /// <summary>
        /// 应用主场景主体ID
        /// </summary>
        [JsonPropertyName("app_main_scene_id")]
        public string AppMainSceneId { get; set; }

        /// <summary>
        /// 应用名称，用于区分内容的应用来源
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 应用场景
        /// </summary>
        [JsonPropertyName("app_scene")]
        public string AppScene { get; set; }

        /// <summary>
        /// 业务ID，例如发帖的帖子ID
        /// </summary>
        [JsonPropertyName("app_scene_data_id")]
        public string AppSceneDataId { get; set; }

        /// <summary>
        /// 进行识别的音频地址列表
        /// </summary>
        [JsonPropertyName("audio_urls")]
        public List<string> AudioUrls { get; set; }

        /// <summary>
        /// 进行识别的链接地址列表
        /// </summary>
        [JsonPropertyName("link_urls")]
        public List<string> LinkUrls { get; set; }

        /// <summary>
        /// 进行识别的图片地址列表
        /// </summary>
        [JsonPropertyName("picture_urls")]
        public List<string> PictureUrls { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [JsonPropertyName("publish_date")]
        public string PublishDate { get; set; }

        /// <summary>
        /// 文本内容
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// 文本类型
        /// </summary>
        [JsonPropertyName("text_type")]
        public string TextType { get; set; }

        /// <summary>
        /// 进行识别的视频地址列表
        /// </summary>
        [JsonPropertyName("video_urls")]
        public List<string> VideoUrls { get; set; }
    }
}
