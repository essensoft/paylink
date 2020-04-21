using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SceneMarketingContent Data Structure.
    /// </summary>
    public class SceneMarketingContent : AlipayObject
    {
        /// <summary>
        /// 美食 娱乐等分类条目
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// 小图标地址
        /// </summary>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 营销图片地址
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; }

        /// <summary>
        /// 营销内容意义
        /// </summary>
        [JsonPropertyName("meaning")]
        public string Meaning { get; set; }

        /// <summary>
        /// 优惠信息的html格式展示参考
        /// </summary>
        [JsonPropertyName("meaning_desc")]
        public string MeaningDesc { get; set; }

        /// <summary>
        /// 营销内容标签
        /// </summary>
        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 限制及特性描述
        /// </summary>
        [JsonPropertyName("tips")]
        public List<string> Tips { get; set; }

        /// <summary>
        /// 营销内容标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 营销内容类型，例如优惠好店，商圈特惠
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 营销内容跳转地址
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
