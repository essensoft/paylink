using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Neighborhood Data Structure.
    /// </summary>
    [Serializable]
    public class Neighborhood : AlipayObject
    {
        /// <summary>
        /// 社区名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// POI类型
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
