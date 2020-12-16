using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniAppdeployBydeployversionQueryResponse.
    /// </summary>
    public class AlipayOpenMiniAppdeployBydeployversionQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序发布信息
        /// </summary>
        [JsonPropertyName("deploys")]
        public List<MiniAppDeployResponse> Deploys { get; set; }
    }
}
