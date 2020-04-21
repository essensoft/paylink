using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniActivityModuleQueryResponse.
    /// </summary>
    public class AlipayOpenMiniActivityModuleQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 本次查询的页码
        /// </summary>
        [JsonPropertyName("current_page_num")]
        public long CurrentPageNum { get; set; }

        /// <summary>
        /// 模块的数据项列表
        /// </summary>
        [JsonPropertyName("data")]
        public List<MiniActivityModuleQueryInfo> Data { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [JsonPropertyName("per_page_count")]
        public long PerPageCount { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果描述信息
        /// </summary>
        [JsonPropertyName("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 调用是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 符合条件的总数量
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
