using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// NewsfeedMediaVideoInfo Data Structure.
    /// </summary>
    public class NewsfeedMediaVideoInfo : AlipayObject
    {
        /// <summary>
        /// 高度
        /// </summary>
        [JsonPropertyName("height")]
        public string Height { get; set; }

        /// <summary>
        /// 视频缩略图的ID（支持djangoId）
        /// </summary>
        [JsonPropertyName("img_id")]
        public string ImgId { get; set; }

        /// <summary>
        /// 视频的id（支持djangoId）
        /// </summary>
        [JsonPropertyName("video_id")]
        public string VideoId { get; set; }

        /// <summary>
        /// 宽度
        /// </summary>
        [JsonPropertyName("width")]
        public string Width { get; set; }
    }
}
