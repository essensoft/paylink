using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherTemplateDeleteModel Data Structure.
    /// </summary>
    public class AlipayMarketingVoucherTemplateDeleteModel : AlipayObject
    {
        /// <summary>
        /// 券模板ID
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }
    }
}
