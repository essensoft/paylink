using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoTokenFastGetModel Data Structure.
    /// </summary>
    public class AlipayEcoTokenFastGetModel : AlipayObject
    {
        /// <summary>
        /// 授权码
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 应用Secret
        /// </summary>
        [JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }
    }
}
