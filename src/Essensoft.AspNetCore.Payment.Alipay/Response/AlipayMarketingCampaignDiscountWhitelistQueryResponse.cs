using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountWhitelistQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignDiscountWhitelistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonProperty("camp_id")]
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 活动id.白名单,","隔开，最多100个
        /// </summary>
        [JsonProperty("user_white_list")]
        [XmlElement("user_white_list")]
        public string UserWhiteList { get; set; }
    }
}
