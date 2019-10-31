using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FeedbackSubItem Data Structure.
    /// </summary>
    [Serializable]
    public class FeedbackSubItem : AlipayObject
    {
        /// <summary>
        /// 评价子项的评分
        /// </summary>
        [JsonProperty("score")]
        public string Score { get; set; }

        /// <summary>
        /// 评价子项的描述
        /// </summary>
        [JsonProperty("sub_item_desc")]
        public string SubItemDesc { get; set; }

        /// <summary>
        /// 评价子项的key
        /// </summary>
        [JsonProperty("sub_item_key")]
        public string SubItemKey { get; set; }
    }
}
