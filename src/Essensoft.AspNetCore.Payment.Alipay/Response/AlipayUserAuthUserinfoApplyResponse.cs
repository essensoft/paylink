using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAuthUserinfoApplyResponse.
    /// </summary>
    public class AlipayUserAuthUserinfoApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 授权的码
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 用户的支付宝id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
