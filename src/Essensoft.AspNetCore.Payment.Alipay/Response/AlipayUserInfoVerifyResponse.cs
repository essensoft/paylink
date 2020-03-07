using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserInfoVerifyResponse.
    /// </summary>
    public class AlipayUserInfoVerifyResponse : AlipayResponse
    {
        /// <summary>
        /// MATCH, 信息匹配  NOT_MATCH, 信息不匹配  UNKNOWN, 未知（未认证的用户在校验姓名是否匹配时返回该结果）
        /// </summary>
        [JsonPropertyName("match_result")]
        public string MatchResult { get; set; }
    }
}
