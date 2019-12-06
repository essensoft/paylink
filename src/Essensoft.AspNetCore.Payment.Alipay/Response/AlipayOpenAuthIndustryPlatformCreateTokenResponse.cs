using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAuthIndustryPlatformCreateTokenResponse.
    /// </summary>
    public class AlipayOpenAuthIndustryPlatformCreateTokenResponse : AlipayResponse
    {
        /// <summary>
        /// 授权码
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// appid
        /// </summary>
        [JsonPropertyName("requst_app_id")]
        public string RequstAppId { get; set; }

        /// <summary>
        /// scope
        /// </summary>
        [JsonPropertyName("scope")]
        public string Scope { get; set; }
    }
}
