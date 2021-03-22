using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCardTemplateQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCardTemplateQueryModel : AlipayObject
    {
        /// <summary>
        /// 会员卡模板id。调用alipay.marketing.card.template.create（会员卡模板创建接口）创建模板后同步返回。
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
