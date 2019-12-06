using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MerchantshopCommentStatistic Data Structure.
    /// </summary>
    public class MerchantshopCommentStatistic : AlipayObject
    {
        /// <summary>
        /// 评论总数
        /// </summary>
        [JsonPropertyName("comment_count")]
        public long CommentCount { get; set; }

        /// <summary>
        /// 评分（平均分），两位小数
        /// </summary>
        [JsonPropertyName("score")]
        public long Score { get; set; }
    }
}
