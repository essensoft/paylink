using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignPrizeAmountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignPrizeAmountQueryModel : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonProperty("camp_id")]
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 奖品id
        /// </summary>
        [JsonProperty("prize_id")]
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }
    }
}
