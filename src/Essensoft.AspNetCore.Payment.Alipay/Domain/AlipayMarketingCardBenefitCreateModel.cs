using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCardBenefitCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCardBenefitCreateModel : AlipayObject
    {
        /// <summary>
        /// 会员卡模板外部权益
        /// </summary>
        [JsonProperty("mcard_template_benefit")]
        [XmlElement("mcard_template_benefit")]
        public McardTemplateBenefit McardTemplateBenefit { get; set; }
    }
}
