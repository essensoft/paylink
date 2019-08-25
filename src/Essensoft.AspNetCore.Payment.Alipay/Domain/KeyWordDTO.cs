using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KeyWordDTO Data Structure.
    /// </summary>
    [Serializable]
    public class KeyWordDTO : AlipayObject
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

        /// <summary>
        /// 置信度打分
        /// </summary>
        [JsonProperty("score")]
        public string Score { get; set; }
    }
}
