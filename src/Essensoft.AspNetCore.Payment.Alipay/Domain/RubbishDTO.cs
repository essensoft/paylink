using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RubbishDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RubbishDTO : AlipayObject
    {
        /// <summary>
        /// 垃圾类别
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// 垃圾名称
        /// </summary>
        [JsonProperty("key_word")]
        public string KeyWord { get; set; }
    }
}
