using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEprintTokenGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEprintTokenGetModel : AlipayObject
    {
        /// <summary>
        /// 是否优先从缓存中拿取，false则强制刷新，1天20次
        /// </summary>
        [JsonProperty("cache_first")]
        public bool CacheFirst { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 应用Secret
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }
    }
}
