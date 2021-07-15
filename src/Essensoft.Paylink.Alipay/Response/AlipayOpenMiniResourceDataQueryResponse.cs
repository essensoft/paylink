using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniResourceDataQueryResponse.
    /// </summary>
    public class AlipayOpenMiniResourceDataQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 流量位数据列表
        /// </summary>
        [JsonPropertyName("resource_data_list")]
        public List<ResourceDataVO> ResourceDataList { get; set; }
    }
}
