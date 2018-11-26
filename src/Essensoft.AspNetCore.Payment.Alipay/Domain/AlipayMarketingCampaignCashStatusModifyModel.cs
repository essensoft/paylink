using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignCashStatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignCashStatusModifyModel : AlipayObject
    {
        /// <summary>
        /// 修改后的活动状态, PAUSE或者READY或者CLOSED
        /// </summary>
        [JsonProperty("camp_status")]
        [XmlElement("camp_status")]
        public string CampStatus { get; set; }

        /// <summary>
        /// 要修改的现金红包活动号
        /// </summary>
        [JsonProperty("crowd_no")]
        [XmlElement("crowd_no")]
        public string CrowdNo { get; set; }
    }
}
