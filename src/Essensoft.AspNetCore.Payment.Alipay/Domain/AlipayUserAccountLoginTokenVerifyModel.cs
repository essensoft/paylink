using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAccountLoginTokenVerifyModel Data Structure.
    /// </summary>
    public class AlipayUserAccountLoginTokenVerifyModel : AlipayObject
    {
        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonPropertyName("extra_params")]
        public VerifyExtraParams ExtraParams { get; set; }

        /// <summary>
        /// 二方登录token
        /// </summary>
        [JsonPropertyName("login_token")]
        public string LoginToken { get; set; }

        /// <summary>
        /// 渠道来源
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }
    }
}
