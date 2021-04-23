using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppServiceListQueryResponse.
    /// </summary>
    public class AlipayOpenAppServiceListQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 服务列表
        /// </summary>
        [JsonPropertyName("records")]
        public List<StandardServiceBaseInfo> Records { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
