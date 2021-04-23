using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AntfortuneContentCommunitySubtitleQueryModel Data Structure.
    /// </summary>
    public class AntfortuneContentCommunitySubtitleQueryModel : AlipayObject
    {
        /// <summary>
        /// 10s内字幕文本，最多1000个字
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 字幕扩展字段
        /// </summary>
        [JsonPropertyName("ext")]
        public AliveSubtitleExt Ext { get; set; }

        /// <summary>
        /// 直播ID
        /// </summary>
        [JsonPropertyName("live_id")]
        public string LiveId { get; set; }
    }
}
