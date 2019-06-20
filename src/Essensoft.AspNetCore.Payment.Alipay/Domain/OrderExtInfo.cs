using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OrderExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrderExtInfo : AlipayObject
    {
        /// <summary>
        /// 键值
        /// </summary>
        [JsonProperty("ext_key")]
        public string ExtKey { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [JsonProperty("ext_value")]
        public string ExtValue { get; set; }
    }
}
