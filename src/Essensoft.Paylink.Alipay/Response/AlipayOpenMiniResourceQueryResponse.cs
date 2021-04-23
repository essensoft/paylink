using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniResourceQueryResponse.
    /// </summary>
    public class AlipayOpenMiniResourceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 数据结果 如果为空, 网关会不透出这个字段
        /// </summary>
        [JsonPropertyName("data_list")]
        public List<QueryMiniResourceResponse> DataList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 数据总量
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
