using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniOperationAppserviceQueryResponse.
    /// </summary>
    public class AlipayOpenMiniOperationAppserviceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 子服务列表
        /// </summary>
        [JsonPropertyName("data_list")]
        public List<AppServiceResult> DataList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 该应用子服务总数
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
