using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCcmInstanceQueryResponse.
    /// </summary>
    public class AlipayIserviceCcmInstanceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 租户实例列表
        /// </summary>
        [JsonPropertyName("instances")]
        public List<Instance> Instances { get; set; }

        /// <summary>
        /// 查询结果的页码
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询时设置的每页记录数
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总条目数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
