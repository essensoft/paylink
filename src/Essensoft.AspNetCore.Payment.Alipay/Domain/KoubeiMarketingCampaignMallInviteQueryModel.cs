using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignMallInviteQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignMallInviteQueryModel : AlipayObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("page_no")]
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [JsonProperty("page_size")]
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
