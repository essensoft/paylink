using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignCrowdDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignCrowdDeleteModel : AlipayObject
    {
        /// <summary>
        /// 人群组的唯一标识ID
        /// </summary>
        [JsonProperty("crowd_group_id")]
        [XmlElement("crowd_group_id")]
        public string CrowdGroupId { get; set; }
    }
}
