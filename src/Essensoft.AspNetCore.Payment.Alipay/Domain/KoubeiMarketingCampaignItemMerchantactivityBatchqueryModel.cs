using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignItemMerchantactivityBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("page_no")]
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页显示内容数
        /// </summary>
        [JsonProperty("page_size")]
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 活动状态
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
