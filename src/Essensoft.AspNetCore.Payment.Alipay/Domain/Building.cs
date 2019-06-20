using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Building Data Structure.
    /// </summary>
    [Serializable]
    public class Building : AlipayObject
    {
        /// <summary>
        /// 建筑名称
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
