using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiShopWxloginQueryResponse.
    /// </summary>
    public class KoubeiShopWxloginQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户唯一标识的 openid
        /// </summary>
        [JsonPropertyName("openid")]
        public string Openid { get; set; }

        /// <summary>
        /// 会话密钥
        /// </summary>
        [JsonPropertyName("session_key")]
        public string SessionKey { get; set; }
    }
}
