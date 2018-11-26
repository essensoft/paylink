using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignIntelligentPromoDeleteModel : AlipayObject
    {
        /// <summary>
        /// 操作下架的操作人信息
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
        /// 智能营销活动的id
        /// </summary>
        [JsonProperty("promo_id")]
        [XmlElement("promo_id")]
        public string PromoId { get; set; }
    }
}
