using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ProdResource Data Structure.
    /// </summary>
    [Serializable]
    public class ProdResource : AlipayObject
    {
        /// <summary>
        /// 资源项唯一标识
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// 资源项名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 资源项类型
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 资源向内容
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
