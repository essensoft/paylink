using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Topic Data Structure.
    /// </summary>
    public class Topic : AlipayObject
    {
        /// <summary>
        /// 营销位图片url
        /// </summary>
        [JsonPropertyName("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 营销位跳转地址，点击营销位头图跳到的链接url。
        /// </summary>
        [JsonPropertyName("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 营销位描述
        /// </summary>
        [JsonPropertyName("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 营销位名称
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 营销位id
        /// </summary>
        [JsonPropertyName("topic_id")]
        public string TopicId { get; set; }

        /// <summary>
        /// 营销位内容列表
        /// </summary>
        [JsonPropertyName("topic_items")]
        public List<TopicItem> TopicItems { get; set; }
    }
}
