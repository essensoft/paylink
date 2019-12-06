using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FeedbackSubItem Data Structure.
    /// </summary>
    public class FeedbackSubItem : AlipayObject
    {
        /// <summary>
        /// 评价子项的评分
        /// </summary>
        [JsonPropertyName("score")]
        public string Score { get; set; }

        /// <summary>
        /// 评价子项的描述
        /// </summary>
        [JsonPropertyName("sub_item_desc")]
        public string SubItemDesc { get; set; }

        /// <summary>
        /// 评价子项的key
        /// </summary>
        [JsonPropertyName("sub_item_key")]
        public string SubItemKey { get; set; }
    }
}
