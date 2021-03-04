using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCashlessvoucherTemplateCreateResponse.
    /// </summary>
    public class AlipayMarketingCashlessvoucherTemplateCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
