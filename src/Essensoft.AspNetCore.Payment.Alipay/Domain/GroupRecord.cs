using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GroupRecord Data Structure.
    /// </summary>
    [Serializable]
    public class GroupRecord : AlipayObject
    {
        /// <summary>
        /// 本次返回的结果数量
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; set; }

        /// <summary>
        /// 展位ID，finetinyapp：精品小程序 finecard：场景card
        /// </summary>
        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 显示名称，可为空
        /// </summary>
        [JsonProperty("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 是否还有更多结果
        /// </summary>
        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 命中结果
        /// </summary>
        [JsonProperty("hits")]
        public List<Hit> Hits { get; set; }

        /// <summary>
        /// 更多显示名称
        /// </summary>
        [JsonProperty("more_link_name")]
        public string MoreLinkName { get; set; }

        /// <summary>
        /// 更多url
        /// </summary>
        [JsonProperty("more_link_url")]
        public string MoreLinkUrl { get; set; }

        /// <summary>
        /// 搜索命中结果总数量
        /// </summary>
        [JsonProperty("total_count")]
        public long TotalCount { get; set; }
    }
}
