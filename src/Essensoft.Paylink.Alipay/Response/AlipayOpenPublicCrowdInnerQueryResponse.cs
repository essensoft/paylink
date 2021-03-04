using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicCrowdInnerQueryResponse.
    /// </summary>
    public class AlipayOpenPublicCrowdInnerQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 人群摘要信息
        /// </summary>
        [JsonPropertyName("crowd_summary")]
        public CrowdSummary CrowdSummary { get; set; }
    }
}
