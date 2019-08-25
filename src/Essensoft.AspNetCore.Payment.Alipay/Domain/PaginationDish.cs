using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PaginationDish Data Structure.
    /// </summary>
    [Serializable]
    public class PaginationDish : AlipayObject
    {
        /// <summary>
        /// 出参列表
        /// </summary>
        [JsonProperty("list")]
        public List<KbdishInfo> List { get; set; }

        /// <summary>
        /// 表示当前页数
        /// </summary>
        [JsonProperty("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 表示每页条数
        /// </summary>
        [JsonProperty("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [JsonProperty("total_count")]
        public string TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonProperty("total_page")]
        public string TotalPage { get; set; }
    }
}
