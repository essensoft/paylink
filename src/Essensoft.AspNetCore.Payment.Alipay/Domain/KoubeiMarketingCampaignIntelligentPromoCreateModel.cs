using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignIntelligentPromoCreateModel : AlipayObject
    {
        /// <summary>
        /// 创建营销方案的上下文信息
        /// </summary>
        [JsonProperty("operator_context")]
        [XmlElement("operator_context")]
        public PromoOperatorInfo OperatorContext { get; set; }

        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [JsonProperty("out_request_no")]
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 智能营销活动信息
        /// </summary>
        [JsonProperty("promo")]
        [XmlElement("promo")]
        public IntelligentPromo Promo { get; set; }
    }
}
