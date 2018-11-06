using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityCreateResponse.
    /// </summary>
    public class KoubeiMarketingCampaignItemMerchantactivityCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 运营活动id
        /// </summary>
        [JsonProperty("activity_id")]
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
