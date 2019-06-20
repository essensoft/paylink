using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemExtInfo : AlipayObject
    {
        /// <summary>
        /// 扩展信息的key
        /// </summary>
        [JsonProperty("ext_key")]
        public string ExtKey { get; set; }

        /// <summary>
        /// 扩展信息的值
        /// </summary>
        [JsonProperty("ext_value")]
        public string ExtValue { get; set; }
    }
}
