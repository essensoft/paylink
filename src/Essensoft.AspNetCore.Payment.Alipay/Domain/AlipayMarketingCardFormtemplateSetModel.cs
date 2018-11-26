using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCardFormtemplateSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCardFormtemplateSetModel : AlipayObject
    {
        /// <summary>
        /// 会员卡开卡时的表单字段配置信息，可定义多个通用表单字段，最大不超过20个。
        /// </summary>
        [JsonProperty("fields")]
        [XmlElement("fields")]
        public OpenFormFieldDO Fields { get; set; }

        /// <summary>
        /// 会员卡模板id。使用会员卡模板创建接口(alipay.marketing.card.template.create)返回的结果
        /// </summary>
        [JsonProperty("template_id")]
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
