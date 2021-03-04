using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCardTemplateModifyResponse.
    /// </summary>
    public class AlipayMarketingCardTemplateModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
