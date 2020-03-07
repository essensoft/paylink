using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LifeRecommendArticles Data Structure.
    /// </summary>
    public class LifeRecommendArticles : AlipayObject
    {
        /// <summary>
        /// 文章id
        /// </summary>
        [JsonPropertyName("article_id")]
        public string ArticleId { get; set; }

        /// <summary>
        /// 文章封面图片
        /// </summary>
        [JsonPropertyName("article_image")]
        public string ArticleImage { get; set; }

        /// <summary>
        /// 支付宝钱包的文章详情地址
        /// </summary>
        [JsonPropertyName("article_link")]
        public string ArticleLink { get; set; }

        /// <summary>
        /// 文章阅读数
        /// </summary>
        [JsonPropertyName("article_read_cnt")]
        public string ArticleReadCnt { get; set; }

        /// <summary>
        /// 文章来源
        /// </summary>
        [JsonPropertyName("article_source")]
        public string ArticleSource { get; set; }

        /// <summary>
        /// 文章的标题
        /// </summary>
        [JsonPropertyName("article_title")]
        public string ArticleTitle { get; set; }
    }
}
