using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignCrowdBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignCrowdBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 人群名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 分页页码，从1开始计数,如果不填写默认为1
        /// </summary>
        [JsonProperty("page_number")]
        [XmlElement("page_number")]
        public string PageNumber { get; set; }

        /// <summary>
        /// 分页大小，每页显示的数目，如果不填写默认为20
        /// </summary>
        [JsonProperty("page_size")]
        [XmlElement("page_size")]
        public string PageSize { get; set; }
    }
}
