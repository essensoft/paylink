using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntfortuneEquityShopCustrelationQueryResponse.
    /// </summary>
    public class AntfortuneEquityShopCustrelationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户关注商户pid对应的财富号的时间
        /// </summary>
        [JsonPropertyName("follow_time")]
        public string FollowTime { get; set; }

        /// <summary>
        /// 当前用户是否关注商户pid对应的财富号
        /// </summary>
        [JsonPropertyName("match_result")]
        public bool MatchResult { get; set; }
    }
}
