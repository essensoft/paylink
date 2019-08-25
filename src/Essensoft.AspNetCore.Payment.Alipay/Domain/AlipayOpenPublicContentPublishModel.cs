using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicContentPublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicContentPublishModel : AlipayObject
    {
        /// <summary>
        /// action_url 文章地址url，用于文章列表显示，用户点击后的跳转地址。
        /// </summary>
        [JsonProperty("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// article_id 为调用方的文章id，用于生活号对输入的文章进行去重检测
        /// </summary>
        [JsonProperty("article_id")]
        public string ArticleId { get; set; }

        /// <summary>
        /// content 为写文章完整的正文文本内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// cover_img 用于内容在文章列表中展示时的配图
        /// </summary>
        [JsonProperty("cover_img")]
        public string CoverImg { get; set; }

        /// <summary>
        /// desc 用于描述文章简介
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// endTime 用于描述文章内容有效截止时间
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// source 用于描述调用接口的业务方
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// title 用于描述文章标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
