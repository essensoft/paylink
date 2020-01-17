using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicTemplateMessageAddResponse.
    /// </summary>
    public class AlipayOpenPublicTemplateMessageAddResponse : AlipayResponse
    {
        /// <summary>
        /// 模板消息的详细信息
        /// </summary>
        [JsonPropertyName("template")]
        public string Template { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
