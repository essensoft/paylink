using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsCertificatePaginationList Data Structure.
    /// </summary>
    public class InsCertificatePaginationList : AlipayObject
    {
        /// <summary>
        /// 当前页数
        /// </summary>
        [JsonPropertyName("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 结果列表
        /// </summary>
        [JsonPropertyName("list")]
        public List<InsCertificateApiDTO> List { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 全部页数
        /// </summary>
        [JsonPropertyName("total_page_num")]
        public long TotalPageNum { get; set; }
    }
}
