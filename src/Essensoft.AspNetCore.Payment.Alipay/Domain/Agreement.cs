using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Agreement Data Structure.
    /// </summary>
    [Serializable]
    public class Agreement : AlipayObject
    {
        /// <summary>
        /// 协议地址
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// 协议名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
