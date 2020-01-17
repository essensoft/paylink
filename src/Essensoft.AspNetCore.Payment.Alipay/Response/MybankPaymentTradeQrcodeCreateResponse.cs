using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankPaymentTradeQrcodeCreateResponse.
    /// </summary>
    public class MybankPaymentTradeQrcodeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 加密的token
        /// </summary>
        [JsonPropertyName("encrypt_token")]
        public string EncryptToken { get; set; }

        /// <summary>
        /// url地址
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
