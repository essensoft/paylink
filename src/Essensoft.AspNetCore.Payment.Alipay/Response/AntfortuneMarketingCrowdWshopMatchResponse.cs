using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntfortuneMarketingCrowdWshopMatchResponse.
    /// </summary>
    public class AntfortuneMarketingCrowdWshopMatchResponse : AlipayResponse
    {
        /// <summary>
        /// 用户是否匹配人群，枚举值：true/false
        /// </summary>
        [JsonPropertyName("match_result")]
        public bool MatchResult { get; set; }
    }
}
