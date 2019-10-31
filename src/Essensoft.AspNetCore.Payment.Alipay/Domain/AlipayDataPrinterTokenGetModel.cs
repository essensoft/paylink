using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataPrinterTokenGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataPrinterTokenGetModel : AlipayObject
    {
        /// <summary>
        /// 应用id
        /// </summary>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 授与方式
        /// </summary>
        [JsonProperty("grant_type")]
        public string GrantType { get; set; }

        /// <summary>
        /// 权限
        /// </summary>
        [JsonProperty("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// 应用秘钥
        /// </summary>
        [JsonProperty("secret")]
        public string Secret { get; set; }
    }
}
