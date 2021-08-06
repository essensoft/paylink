using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BoxExclusiveMarketingPageQueryDTO Data Structure.
    /// </summary>
    public class BoxExclusiveMarketingPageQueryDTO : AlipayObject
    {
        /// <summary>
        /// box活动详情
        /// </summary>
        [JsonPropertyName("page_data")]
        public List<SearchBoxExclusiveMarketingInfoRequest> PageData { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonPropertyName("total_number")]
        public string TotalNumber { get; set; }
    }
}
