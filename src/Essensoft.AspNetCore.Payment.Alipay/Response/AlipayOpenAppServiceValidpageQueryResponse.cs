using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppServiceValidpageQueryResponse.
    /// </summary>
    public class AlipayOpenAppServiceValidpageQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前页
        /// </summary>
        [JsonPropertyName("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 每页显示多少条
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 服务基础信息
        /// </summary>
        [JsonPropertyName("service_list")]
        public List<ServiceBase> ServiceList { get; set; }

        /// <summary>
        /// 记录总条数
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
