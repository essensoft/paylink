using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignActivityQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignActivityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动详情
        /// </summary>
        [JsonProperty("camp_detail")]
        [XmlElement("camp_detail")]
        public CampDetail CampDetail { get; set; }
    }
}
