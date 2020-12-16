using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateTextMessageDTO Data Structure.
    /// </summary>
    public class TemplateTextMessageDTO : AlipayObject
    {
        /// <summary>
        /// 标签标题文案，支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("label")]
        public string Label { get; set; }

        /// <summary>
        /// 模版标签值，支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
