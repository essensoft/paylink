using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MaterialCreateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MaterialCreateInfo : AlipayObject
    {
        /// <summary>
        /// 素材内容（素材地址或素材KEY）
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 素材类型
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
