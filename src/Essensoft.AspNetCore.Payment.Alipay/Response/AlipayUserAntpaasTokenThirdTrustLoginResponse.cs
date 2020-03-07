using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAntpaasTokenThirdTrustLoginResponse.
    /// </summary>
    public class AlipayUserAntpaasTokenThirdTrustLoginResponse : AlipayResponse
    {
        /// <summary>
        /// third_trust_token：用户免登的一次性token；后续使用改token进行免登请求。
        /// </summary>
        [JsonPropertyName("third_trust_token")]
        public string ThirdTrustToken { get; set; }
    }
}
