using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAccountLoginTokenVerifyResponse.
    /// </summary>
    public class AlipayUserAccountLoginTokenVerifyResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝用户uid
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }
    }
}
