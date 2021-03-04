using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherTemplatedetailQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingVoucherTemplatedetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 券模板ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
