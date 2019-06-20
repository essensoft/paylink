using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Dimension Data Structure.
    /// </summary>
    [Serializable]
    public class Dimension : AlipayObject
    {
        /// <summary>
        /// 维度类型
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 维度值
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
