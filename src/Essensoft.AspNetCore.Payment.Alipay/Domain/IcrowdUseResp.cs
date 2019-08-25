using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IcrowdUseResp Data Structure.
    /// </summary>
    [Serializable]
    public class IcrowdUseResp : AlipayObject
    {
        /// <summary>
        /// 方法ID
        /// </summary>
        [JsonProperty("method_id")]
        public string MethodId { get; set; }

        /// <summary>
        /// 方法返回结果
        /// </summary>
        [JsonProperty("ret_val")]
        public string RetVal { get; set; }
    }
}
