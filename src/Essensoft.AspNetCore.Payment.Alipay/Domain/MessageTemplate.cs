using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MessageTemplate Data Structure.
    /// </summary>
    public class MessageTemplate : AlipayObject
    {
        /// <summary>
        /// 消息主体
        /// </summary>
        [JsonPropertyName("context")]
        public MessageContext Context { get; set; }

        /// <summary>
        /// 消息模板ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
