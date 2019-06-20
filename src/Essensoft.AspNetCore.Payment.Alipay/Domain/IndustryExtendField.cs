using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IndustryExtendField Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryExtendField : AlipayObject
    {
        /// <summary>
        /// 扩展参数的key值
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// 扩展参数的value值
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
