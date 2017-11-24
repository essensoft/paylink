using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// MerchantshopCommentStatistic Data Structure.
    /// </summary>
    public class MerchantshopCommentStatistic : AlipayObject
    {
        /// <summary>
        /// 评论总数
        /// </summary>
        [JsonProperty("comment_count")]
        public long CommentCount { get; set; }

        /// <summary>
        /// 评分（平均分），两位小数
        /// </summary>
        [JsonProperty("score")]
        public long Score { get; set; }
    }
}
