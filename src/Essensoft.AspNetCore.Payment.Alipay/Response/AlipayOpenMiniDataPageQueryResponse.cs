using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniDataPageQueryResponse.
    /// </summary>
    public class AlipayOpenMiniDataPageQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 页面访问数据结果
        /// </summary>
        [JsonPropertyName("page_visit_data_list_response")]
        public List<PageVisitDataResponse> PageVisitDataListResponse { get; set; }
    }
}
