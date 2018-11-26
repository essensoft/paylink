using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignCashListQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignCashListQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动列表
        /// </summary>
        [JsonProperty("camp_list")]
        [XmlArray("camp_list")]
        [XmlArrayItem("cash_campaign_info")]
        public List<CashCampaignInfo> CampList { get; set; }

        /// <summary>
        /// 分页的页码,起始从1开始
        /// </summary>
        [JsonProperty("page_index")]
        [XmlElement("page_index")]
        public string PageIndex { get; set; }

        /// <summary>
        /// 分页每页大小
        /// </summary>
        [JsonProperty("page_size")]
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 活动总个数
        /// </summary>
        [JsonProperty("total_size")]
        [XmlElement("total_size")]
        public string TotalSize { get; set; }
    }
}
