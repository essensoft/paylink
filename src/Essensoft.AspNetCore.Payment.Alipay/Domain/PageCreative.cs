using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PageCreative Data Structure.
    /// </summary>
    public class PageCreative : AlipayObject
    {
        /// <summary>
        /// 创意详情列表
        /// </summary>
        [JsonPropertyName("list")]
        public List<CreativeDetail> List { get; set; }

        /// <summary>
        /// 创意分页信息
        /// </summary>
        [JsonPropertyName("pagination")]
        public PageInfo Pagination { get; set; }
    }
}
