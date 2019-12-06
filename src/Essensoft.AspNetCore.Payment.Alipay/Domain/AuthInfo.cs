using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AuthInfo Data Structure.
    /// </summary>
    public class AuthInfo : AlipayObject
    {
        /// <summary>
        /// 授权号
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 授权类型
        /// </summary>
        [JsonPropertyName("auth_type")]
        public string AuthType { get; set; }
    }
}
