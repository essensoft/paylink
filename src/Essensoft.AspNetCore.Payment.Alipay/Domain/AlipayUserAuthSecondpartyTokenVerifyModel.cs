using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAuthSecondpartyTokenVerifyModel Data Structure.
    /// </summary>
    public class AlipayUserAuthSecondpartyTokenVerifyModel : AlipayObject
    {
        /// <summary>
        /// 二方登录token
        /// </summary>
        [JsonPropertyName("second_party_token")]
        public string SecondPartyToken { get; set; }

        /// <summary>
        /// 渠道来源
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }
    }
}
