using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 版本列表
        /// </summary>
        [JsonPropertyName("version_list")]
        public List<MiniAppVersionBaseInfo> VersionList { get; set; }
    }
}
