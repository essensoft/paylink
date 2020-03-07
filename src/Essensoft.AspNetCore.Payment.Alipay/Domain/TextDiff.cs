using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TextDiff Data Structure.
    /// </summary>
    public class TextDiff : AlipayObject
    {
        /// <summary>
        /// 操作类型
        /// </summary>
        [JsonPropertyName("operation")]
        public string Operation { get; set; }

        /// <summary>
        /// 文本内容
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
