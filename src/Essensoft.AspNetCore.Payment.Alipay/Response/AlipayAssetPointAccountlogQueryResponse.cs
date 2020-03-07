using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAssetPointAccountlogQueryResponse.
    /// </summary>
    public class AlipayAssetPointAccountlogQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前页数
        /// </summary>
        [JsonPropertyName("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 单页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 集分宝账户流水详情列表
        /// </summary>
        [JsonPropertyName("point_account_logs")]
        public List<PointAccountLog> PointAccountLogs { get; set; }

        /// <summary>
        /// 集分宝流水总条数,返回满足条件的集分宝流水的总条数。
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 总页数，根据totalcount和pagesize计算出来
        /// </summary>
        [JsonPropertyName("total_pages")]
        public long TotalPages { get; set; }
    }
}
