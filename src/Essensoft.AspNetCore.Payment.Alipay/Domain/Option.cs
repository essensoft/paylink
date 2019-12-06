using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Option Data Structure.
    /// </summary>
    public class Option : AlipayObject
    {
        /// <summary>
        /// 文本，通常用于理解对应的取值
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// 取值，通常使用简单的数字或字符串
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
