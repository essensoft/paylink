using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniShopRelationQueryResponse.
    /// </summary>
    public class AlipayOpenMiniShopRelationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("current_page_num")]
        public long CurrentPageNum { get; set; }

        /// <summary>
        /// 小程序门店绑定关系列表，principal_id为小程序id，entity_id为门店id
        /// </summary>
        [JsonPropertyName("data_list")]
        public List<MiniEntityBindVO> DataList { get; set; }

        /// <summary>
        /// 每页项数
        /// </summary>
        [JsonPropertyName("per_page_count")]
        public long PerPageCount { get; set; }

        /// <summary>
        /// 总共项数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
