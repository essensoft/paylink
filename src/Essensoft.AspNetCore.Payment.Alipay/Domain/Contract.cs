using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Contract Data Structure.
    /// </summary>
    [Serializable]
    public class Contract : AlipayObject
    {
        /// <summary>
        /// 合约文本内容
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// 合约标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 合约类型
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
