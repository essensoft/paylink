using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// PaginationScenicInfo Data Structure.
    /// </summary>
    public class PaginationScenicInfo : AlipayObject
    {
        /// <summary>
        /// 页码，表示当前页数
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 景区信息
        /// </summary>
        [JsonPropertyName("scenic_info")]
        public List<ScenicInfo> ScenicInfo { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("total_page")]
        public long TotalPage { get; set; }
    }
}
