using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MakePriceAgrs Data Structure.
    /// </summary>
    [Serializable]
    public class MakePriceAgrs : AlipayObject
    {
        /// <summary>
        /// 属性名称
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
