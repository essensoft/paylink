using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerBizruleMatchResponse.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerBizruleMatchResponse : AlipayResponse
    {
        /// <summary>
        /// 匹配详情
        /// </summary>
        [JsonPropertyName("match_result")]
        public string MatchResult { get; set; }
    }
}
