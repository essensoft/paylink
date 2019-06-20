using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Command Data Structure.
    /// </summary>
    [Serializable]
    public class Command : AlipayObject
    {
        /// <summary>
        /// 下发者
        /// </summary>
        [JsonProperty("commander")]
        public string Commander { get; set; }

        /// <summary>
        /// 键:值
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 执行者
        /// </summary>
        [JsonProperty("executor")]
        public string Executor { get; set; }

        /// <summary>
        /// bean.method
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }
    }
}
