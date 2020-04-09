using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PaginationCommGroup Data Structure.
    /// </summary>
    public class PaginationCommGroup : AlipayObject
    {
        /// <summary>
        /// 出参列表
        /// </summary>
        [JsonPropertyName("list")]
        public List<KbdishCommGroupInfo> List { get; set; }

        /// <summary>
        /// 页码，表示当前页数
        /// </summary>
        [JsonPropertyName("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [JsonPropertyName("total_count")]
        public string TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("total_page")]
        public string TotalPage { get; set; }
    }
}
