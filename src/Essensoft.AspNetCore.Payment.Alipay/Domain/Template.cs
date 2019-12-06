using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Template Data Structure.
    /// </summary>
    public class Template : AlipayObject
    {
        /// <summary>
        /// 消息模板上下文，即模板中定义的参数及参数值
        /// </summary>
        [JsonPropertyName("context")]
        public Context Context { get; set; }

        /// <summary>
        /// 消息模板ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
