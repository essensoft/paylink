using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenCategoryArticleQueryResponse.
    /// </summary>
    public class AlipayOpenCategoryArticleQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 文章列表
        /// </summary>
        [JsonPropertyName("articles")]
        public List<LifeRecommendArticles> Articles { get; set; }
    }
}
