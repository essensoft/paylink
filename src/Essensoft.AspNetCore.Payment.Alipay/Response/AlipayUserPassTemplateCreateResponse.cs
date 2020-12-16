using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserPassTemplateCreateResponse.
    /// </summary>
    public class AlipayUserPassTemplateCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝模版ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
