using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCardActivateurlQueryModel Data Structure.
    /// </summary>
    public class AlipayUserCardActivateurlQueryModel : AlipayObject
    {
        /// <summary>
        /// 会员卡模板id。使用会员卡模板创建接口(alipay.marketing.card.template.create)返回的结果
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
