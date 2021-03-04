using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayUserAgreementUserverifyQueryResponse.
    /// </summary>
    public class AlipayUserAgreementUserverifyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户信息是否匹配
        /// </summary>
        [JsonPropertyName("user_match")]
        public bool UserMatch { get; set; }
    }
}
