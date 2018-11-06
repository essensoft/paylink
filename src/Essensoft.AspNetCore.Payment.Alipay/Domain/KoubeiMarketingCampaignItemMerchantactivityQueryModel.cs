using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignItemMerchantactivityQueryModel : AlipayObject
    {
        /// <summary>
        /// 运营活动id
        /// </summary>
        [JsonProperty("activity_id")]
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 外部id
        /// </summary>
        [JsonProperty("external_unique_id")]
        [XmlElement("external_unique_id")]
        public string ExternalUniqueId { get; set; }
    }
}
