using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IcrowdUseParam Data Structure.
    /// </summary>
    public class IcrowdUseParam : AlipayObject
    {
        /// <summary>
        /// 接口上下文
        /// </summary>
        [JsonPropertyName("context")]
        public IcrowdUseContext Context { get; set; }

        /// <summary>
        /// 额外信息
        /// </summary>
        [JsonPropertyName("external_info")]
        public List<string> ExternalInfo { get; set; }

        /// <summary>
        /// 要调用的方法ID
        /// </summary>
        [JsonPropertyName("method_id")]
        public string MethodId { get; set; }
    }
}
