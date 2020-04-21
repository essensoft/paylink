using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEprintTokenRefreshModel Data Structure.
    /// </summary>
    public class AlipayEcoEprintTokenRefreshModel : AlipayObject
    {
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

        /// <summary>
        /// 刷新Token
        /// </summary>
        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
