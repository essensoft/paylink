using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MExtInfo : AlipayObject
    {
        /// <summary>
        /// 扩展信息key值
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// 扩展信息value值
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
