using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MerchantshopCommentStatistic Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantshopCommentStatistic : AlipayObject
    {
        /// <summary>
        /// 评论总数
        /// </summary>
        [JsonProperty("comment_count")]
        [XmlElement("comment_count")]
        public long CommentCount { get; set; }

        /// <summary>
        /// 评分（平均分），两位小数
        /// </summary>
        [JsonProperty("score")]
        [XmlElement("score")]
        public long Score { get; set; }
    }
}
