using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsMarketingCampaignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsMarketingCampaignQueryModel : AlipayObject
    {
        /// <summary>
        /// 保险营销活动Id
        /// </summary>
        [JsonProperty("campaign_id")]
        [XmlElement("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// 请求流水Id
        /// </summary>
        [JsonProperty("request_id")]
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
