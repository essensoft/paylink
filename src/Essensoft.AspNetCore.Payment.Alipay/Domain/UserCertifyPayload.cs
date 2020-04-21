using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserCertifyPayload Data Structure.
    /// </summary>
    public class UserCertifyPayload : AlipayObject
    {
        /// <summary>
        /// 授权编码
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }
    }
}
