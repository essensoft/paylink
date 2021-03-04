using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
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
