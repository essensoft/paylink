using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// NewsfeedMediaGiftInfo Data Structure.
    /// </summary>
    public class NewsfeedMediaGiftInfo : AlipayObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 安卓的高度
        /// </summary>
        [JsonPropertyName("adr_height")]
        public string AdrHeight { get; set; }

        /// <summary>
        /// 安卓缩略图
        /// </summary>
        [JsonPropertyName("adr_thumb")]
        public string AdrThumb { get; set; }

        /// <summary>
        /// 安卓宽度
        /// </summary>
        [JsonPropertyName("adr_width")]
        public string AdrWidth { get; set; }

        /// <summary>
        /// ios高度
        /// </summary>
        [JsonPropertyName("ios_height")]
        public string IosHeight { get; set; }

        /// <summary>
        /// ios缩略图
        /// </summary>
        [JsonPropertyName("ios_thumb")]
        public string IosThumb { get; set; }

        /// <summary>
        /// ios宽度
        /// </summary>
        [JsonPropertyName("ios_width")]
        public string IosWidth { get; set; }

        /// <summary>
        /// 大图
        /// </summary>
        [JsonPropertyName("theme")]
        public string Theme { get; set; }

        /// <summary>
        /// 红包类型all、f、m
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
