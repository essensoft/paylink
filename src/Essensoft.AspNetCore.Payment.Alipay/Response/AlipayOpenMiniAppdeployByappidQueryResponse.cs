using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniAppdeployByappidQueryResponse.
    /// </summary>
    public class AlipayOpenMiniAppdeployByappidQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序发布信息
        /// </summary>
        [JsonPropertyName("deploys")]
        public List<MiniAppDeployResponse> Deploys { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
