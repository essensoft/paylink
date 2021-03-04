using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayAssetCardNewtemplateCreateResponse.
    /// </summary>
    public class AlipayAssetCardNewtemplateCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 模板id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
