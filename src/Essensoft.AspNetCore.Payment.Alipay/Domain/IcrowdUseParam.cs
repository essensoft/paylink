using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IcrowdUseParam Data Structure.
    /// </summary>
    [Serializable]
    public class IcrowdUseParam : AlipayObject
    {
        /// <summary>
        /// 接口上下文
        /// </summary>
        [JsonProperty("context")]
        public IcrowdUseContext Context { get; set; }

        /// <summary>
        /// 额外信息
        /// </summary>
        [JsonProperty("external_info")]
        public List<string> ExternalInfo { get; set; }

        /// <summary>
        /// 要调用的方法ID
        /// </summary>
        [JsonProperty("method_id")]
        public string MethodId { get; set; }
    }
}
