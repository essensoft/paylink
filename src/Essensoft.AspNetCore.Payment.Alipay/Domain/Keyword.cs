using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Keyword Data Structure.
    /// </summary>
    public class Keyword : AlipayObject
    {
        /// <summary>
        /// 当前文字颜色
        /// </summary>
        [JsonPropertyName("color")]
        public string Color { get; set; }

        /// <summary>
        /// 模板中占位符的值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
