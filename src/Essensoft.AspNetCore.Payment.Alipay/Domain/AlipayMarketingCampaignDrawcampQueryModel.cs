using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignDrawcampQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignDrawcampQueryModel : AlipayObject
    {
        /// <summary>
        /// 抽奖活动id，通过alipay.marketing.campaign.drawcamp.create接口返回
        /// </summary>
        [JsonProperty("camp_id")]
        [XmlElement("camp_id")]
        public string CampId { get; set; }
    }
}
