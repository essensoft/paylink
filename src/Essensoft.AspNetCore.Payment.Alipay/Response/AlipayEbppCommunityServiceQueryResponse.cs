using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppCommunityServiceQueryResponse.
    /// </summary>
    public class AlipayEbppCommunityServiceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 服务查询列表
        /// </summary>
        [JsonPropertyName("service_info_list")]
        public List<CommunityServiceInfo> ServiceInfoList { get; set; }
    }
}
