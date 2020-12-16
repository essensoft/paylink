using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniAppdeployByappversionQueryResponse.
    /// </summary>
    public class AlipayOpenMiniAppdeployByappversionQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 发布信息
        /// </summary>
        [JsonPropertyName("deploys")]
        public List<MiniAppDeployResponse> Deploys { get; set; }
    }
}
