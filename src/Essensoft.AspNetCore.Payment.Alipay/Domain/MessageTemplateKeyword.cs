using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MessageTemplateKeyword Data Structure.
    /// </summary>
    public class MessageTemplateKeyword : AlipayObject
    {
        /// <summary>
        /// 颜色
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
