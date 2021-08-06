using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayFincoreComplianceRcsmartLivecontentQueryResponse.
    /// </summary>
    public class AlipayFincoreComplianceRcsmartLivecontentQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 直播信息列表
        /// </summary>
        [JsonPropertyName("live_info_list")]
        public List<LiveInfo> LiveInfoList { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
