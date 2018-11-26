using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoConsultResponse.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentPromoConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 智能营销方案咨询的模型
        /// </summary>
        [JsonProperty("promo")]
        [XmlElement("promo")]
        public IntelligentPromo Promo { get; set; }
    }
}
