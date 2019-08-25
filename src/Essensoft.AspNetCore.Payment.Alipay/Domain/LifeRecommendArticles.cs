using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LifeRecommendArticles Data Structure.
    /// </summary>
    [Serializable]
    public class LifeRecommendArticles : AlipayObject
    {
        /// <summary>
        /// 文章id
        /// </summary>
        [JsonProperty("article_id")]
        public string ArticleId { get; set; }

        /// <summary>
        /// 文章封面图片
        /// </summary>
        [JsonProperty("article_image")]
        public string ArticleImage { get; set; }

        /// <summary>
        /// 支付宝钱包的文章详情地址
        /// </summary>
        [JsonProperty("article_link")]
        public string ArticleLink { get; set; }

        /// <summary>
        /// 文章阅读数
        /// </summary>
        [JsonProperty("article_read_cnt")]
        public string ArticleReadCnt { get; set; }

        /// <summary>
        /// 文章来源
        /// </summary>
        [JsonProperty("article_source")]
        public string ArticleSource { get; set; }

        /// <summary>
        /// 文章的标题
        /// </summary>
        [JsonProperty("article_title")]
        public string ArticleTitle { get; set; }
    }
}
