using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEprintTokenGetModel Data Structure.
    /// </summary>
    public class AlipayEcoEprintTokenGetModel : AlipayObject
    {
        /// <summary>
        /// 是否优先从缓存中拿取，false则强制刷新，1天20次
        /// </summary>
        [JsonPropertyName("cache_first")]
        public bool CacheFirst { get; set; }

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
