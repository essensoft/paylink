using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SearchQueryBoxMarketingRequest Data Structure.
    /// </summary>
    public class SearchQueryBoxMarketingRequest : AlipayObject
    {
        /// <summary>
        /// 品牌id
        /// </summary>
        [JsonPropertyName("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 是否模糊匹配
        /// </summary>
        [JsonPropertyName("fuzzy_matching")]
        public bool FuzzyMatching { get; set; }

        /// <summary>
        /// 工单id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [JsonPropertyName("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页显示条数
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 查询上一个版本
        /// </summary>
        [JsonPropertyName("query_last_version")]
        public bool QueryLastVersion { get; set; }

        /// <summary>
        /// 查询关联服务的信息
        /// </summary>
        [JsonPropertyName("query_serv_info")]
        public bool QueryServInfo { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonPropertyName("status_list")]
        public List<string> StatusList { get; set; }
    }
}
