using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherTemplateDeleteModel Data Structure.
    /// </summary>
    public class AlipayMarketingVoucherTemplateDeleteModel : AlipayObject
    {
        /// <summary>
        /// 券模板ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
