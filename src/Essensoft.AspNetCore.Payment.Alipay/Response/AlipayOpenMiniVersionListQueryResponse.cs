using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniVersionListQueryResponse.
    /// </summary>
    public class AlipayOpenMiniVersionListQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序的版本号列表
        /// </summary>
        [JsonProperty("app_versions")]
        public List<string> AppVersions { get; set; }
    }
}
