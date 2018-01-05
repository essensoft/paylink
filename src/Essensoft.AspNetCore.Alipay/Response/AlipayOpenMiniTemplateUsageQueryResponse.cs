using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniTemplateUsageQueryResponse.
    /// </summary>
    public class AlipayOpenMiniTemplateUsageQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序appId列表
        /// </summary>
        [JsonProperty("app_ids")]
        public List<string> AppIds { get; set; }
    }
}
