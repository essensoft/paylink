using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignRecruitShopQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignRecruitShopQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 招商活动id
        /// </summary>
        [JsonProperty("plan_id")]
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 总量
        /// </summary>
        [JsonProperty("shop_count")]
        [XmlElement("shop_count")]
        public string ShopCount { get; set; }

        /// <summary>
        /// 招商门店确认详情
        /// </summary>
        [JsonProperty("shop_info")]
        [XmlArray("shop_info")]
        [XmlArrayItem("recruit_shop_info")]
        public List<RecruitShopInfo> ShopInfo { get; set; }
    }
}
