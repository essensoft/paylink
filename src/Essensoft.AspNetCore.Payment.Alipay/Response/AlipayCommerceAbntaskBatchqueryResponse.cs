using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceAbntaskBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceAbntaskBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前页码，不传默认为1
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数据量，正整数，不传默认为1000，超过1000也认定为1000
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 任务信息列表
        /// </summary>
        [JsonPropertyName("task_list")]
        public List<AbnTaskInfo> TaskList { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("total_page")]
        public long TotalPage { get; set; }
    }
}
