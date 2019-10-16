using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TextDiff Data Structure.
    /// </summary>
    [Serializable]
    public class TextDiff : AlipayObject
    {
        /// <summary>
        /// 操作类型
        /// </summary>
        [JsonProperty("operation")]
        public string Operation { get; set; }

        /// <summary>
        /// 文本内容
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
