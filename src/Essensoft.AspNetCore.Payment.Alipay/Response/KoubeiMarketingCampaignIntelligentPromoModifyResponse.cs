using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoModifyResponse.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentPromoModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 修改后返回的智能活动模型
        /// </summary>
        [JsonProperty("promo")]
        [XmlElement("promo")]
        public IntelligentPromo Promo { get; set; }
    }
}
