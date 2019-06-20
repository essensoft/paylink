using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// NewsfeedMediaGiftInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NewsfeedMediaGiftInfo : AlipayObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// 安卓的高度
        /// </summary>
        [JsonProperty("adr_height")]
        public string AdrHeight { get; set; }

        /// <summary>
        /// 安卓缩略图
        /// </summary>
        [JsonProperty("adr_thumb")]
        public string AdrThumb { get; set; }

        /// <summary>
        /// 安卓宽度
        /// </summary>
        [JsonProperty("adr_width")]
        public string AdrWidth { get; set; }

        /// <summary>
        /// ios高度
        /// </summary>
        [JsonProperty("ios_height")]
        public string IosHeight { get; set; }

        /// <summary>
        /// ios缩略图
        /// </summary>
        [JsonProperty("ios_thumb")]
        public string IosThumb { get; set; }

        /// <summary>
        /// ios宽度
        /// </summary>
        [JsonProperty("ios_width")]
        public string IosWidth { get; set; }

        /// <summary>
        /// 大图
        /// </summary>
        [JsonProperty("theme")]
        public string Theme { get; set; }

        /// <summary>
        /// 红包类型all、f、m
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
