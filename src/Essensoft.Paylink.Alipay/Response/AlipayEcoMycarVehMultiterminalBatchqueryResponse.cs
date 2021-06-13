using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarVehMultiterminalBatchqueryResponse.
    /// </summary>
    public class AlipayEcoMycarVehMultiterminalBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 分页页码
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 搜索结果
        /// </summary>
        [JsonPropertyName("search_list")]
        public List<VehSearchItem> SearchList { get; set; }

        /// <summary>
        /// 总页码
        /// </summary>
        [JsonPropertyName("total_page")]
        public long TotalPage { get; set; }

        /// <summary>
        /// 数据总量
        /// </summary>
        [JsonPropertyName("total_size")]
        public long TotalSize { get; set; }
    }
}
