using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSignTokenQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSignTokenQueryModel : AlipayObject
    {
        /// <summary>
        /// 加密TOKEN
        /// </summary>
        [JsonProperty("token_key")]
        public string TokenKey { get; set; }
    }
}
