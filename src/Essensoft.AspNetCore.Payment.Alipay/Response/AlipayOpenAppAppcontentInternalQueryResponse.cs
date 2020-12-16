using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppAppcontentInternalQueryResponse.
    /// </summary>
    public class AlipayOpenAppAppcontentInternalQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页条数
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 服务列表
        /// </summary>
        [JsonPropertyName("service_list")]
        public List<ServiceInfo> ServiceList { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [JsonPropertyName("total")]
        public string Total { get; set; }
    }
}
