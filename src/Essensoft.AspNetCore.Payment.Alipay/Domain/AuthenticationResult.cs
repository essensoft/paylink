using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AuthenticationResult Data Structure.
    /// </summary>
    public class AuthenticationResult : AlipayObject
    {
        /// <summary>
        /// 已加密的鉴权数据
        /// </summary>
        [JsonPropertyName("authentication_data")]
        public string AuthenticationData { get; set; }

        /// <summary>
        /// 鉴权类型，如：支付密码、数字签名
        /// </summary>
        [JsonPropertyName("authentication_mechanism")]
        public string AuthenticationMechanism { get; set; }
    }
}
