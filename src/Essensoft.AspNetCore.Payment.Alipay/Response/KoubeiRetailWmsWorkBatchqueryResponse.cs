using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiRetailWmsWorkBatchqueryResponse.
    /// </summary>
    public class KoubeiRetailWmsWorkBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询条件下作业总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 作业列表
        /// </summary>
        [JsonPropertyName("work_list")]
        public List<WorkListVO> WorkList { get; set; }
    }
}
