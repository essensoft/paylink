using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoTokenFastGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoTokenFastGetModel : AlipayObject
    {
        /// <summary>
        /// 授权码
        /// </summary>
        [JsonProperty("auth_code")]
        public string AuthCode { get; set; }

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
