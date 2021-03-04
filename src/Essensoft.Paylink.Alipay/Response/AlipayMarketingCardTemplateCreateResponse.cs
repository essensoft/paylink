using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCardTemplateCreateResponse.
    /// </summary>
    public class AlipayMarketingCardTemplateCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝卡模板ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
