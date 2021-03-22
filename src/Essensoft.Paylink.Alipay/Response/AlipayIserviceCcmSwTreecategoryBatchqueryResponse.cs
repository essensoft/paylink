using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwTreecategoryBatchqueryResponse.
    /// </summary>
    public class AlipayIserviceCcmSwTreecategoryBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 节点集合
        /// </summary>
        [JsonPropertyName("categories")]
        public List<ArticleCategoryInfo> Categories { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页显示大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总行数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
