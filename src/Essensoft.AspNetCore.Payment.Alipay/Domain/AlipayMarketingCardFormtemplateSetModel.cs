using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCardFormtemplateSetModel Data Structure.
    /// </summary>
    public class AlipayMarketingCardFormtemplateSetModel : AlipayObject
    {
        /// <summary>
        /// 会员卡开卡时的表单字段配置信息，可定义多个通用表单字段，最大不超过20个。
        /// </summary>
        [JsonPropertyName("fields")]
        public OpenFormFieldDO Fields { get; set; }

        /// <summary>
        /// 会员卡模板id。使用会员卡模板创建接口(alipay.marketing.card.template.create)返回的结果
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
