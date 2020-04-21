using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Command Data Structure.
    /// </summary>
    public class Command : AlipayObject
    {
        /// <summary>
        /// 下发者
        /// </summary>
        [JsonPropertyName("commander")]
        public string Commander { get; set; }

        /// <summary>
        /// 键:值
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 执行者
        /// </summary>
        [JsonPropertyName("executor")]
        public string Executor { get; set; }

        /// <summary>
        /// bean.method
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }
    }
}
