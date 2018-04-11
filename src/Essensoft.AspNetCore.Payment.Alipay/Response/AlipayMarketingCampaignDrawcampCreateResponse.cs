using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignDrawcampCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignDrawcampCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 抽奖活动id
        /// </summary>
        [JsonProperty("camp_id")]
        [XmlElement("camp_id")]
        public string CampId { get; set; }
    }
}
