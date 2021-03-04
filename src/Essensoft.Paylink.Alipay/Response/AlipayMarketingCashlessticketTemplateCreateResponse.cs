using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCashlessticketTemplateCreateResponse.
    /// </summary>
    public class AlipayMarketingCashlessticketTemplateCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 票模板id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
