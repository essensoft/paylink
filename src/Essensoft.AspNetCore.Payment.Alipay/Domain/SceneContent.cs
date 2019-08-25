using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SceneContent Data Structure.
    /// </summary>
    [Serializable]
    public class SceneContent : AlipayObject
    {
        /// <summary>
        /// 文章分类
        /// </summary>
        [JsonProperty("article_classify")]
        public long ArticleClassify { get; set; }

        /// <summary>
        /// 文章作者
        /// </summary>
        [JsonProperty("author")]
        public string Author { get; set; }

        /// <summary>
        /// 文章id
        /// </summary>
        [JsonProperty("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 文章封面图片
        /// </summary>
        [JsonProperty("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// 文章图片列表
        /// </summary>
        [JsonProperty("image_list")]
        public List<string> ImageList { get; set; }

        /// <summary>
        /// 生活号id
        /// </summary>
        [JsonProperty("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// public_name为生活号名称，属于公开信息，无需脱敏
        /// </summary>
        [JsonProperty("public_name")]
        public string PublicName { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        /// <summary>
        /// 推荐埋点
        /// </summary>
        [JsonProperty("scm")]
        public string Scm { get; set; }

        /// <summary>
        /// 文章摘要
        /// </summary>
        [JsonProperty("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// 文章标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 文章点赞数
        /// </summary>
        [JsonProperty("total_praise_count")]
        public long TotalPraiseCount { get; set; }

        /// <summary>
        /// 文章回复数
        /// </summary>
        [JsonProperty("total_reply_count")]
        public long TotalReplyCount { get; set; }

        /// <summary>
        /// 文章阅读数
        /// </summary>
        [JsonProperty("total_view_count")]
        public long TotalViewCount { get; set; }

        /// <summary>
        /// 文章类型
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
