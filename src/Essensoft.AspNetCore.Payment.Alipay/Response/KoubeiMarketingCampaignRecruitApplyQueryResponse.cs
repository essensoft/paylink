using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignRecruitApplyQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignRecruitApplyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动开始购买时间
        /// </summary>
        [JsonProperty("bought_time")]
        [XmlElement("bought_time")]
        public string BoughtTime { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [JsonProperty("end_time")]
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 招商报名数据总数
        /// </summary>
        [JsonProperty("item_count")]
        [XmlElement("item_count")]
        public string ItemCount { get; set; }

        /// <summary>
        /// 招商报名数据
        /// </summary>
        [JsonProperty("item_info")]
        [XmlArray("item_info")]
        [XmlArrayItem("recruit_item_apply_data")]
        public List<RecruitItemApplyData> ItemInfo { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 预热开始时间 2016-12-12 10:10:10
        /// </summary>
        [JsonProperty("prehot_time")]
        [XmlElement("prehot_time")]
        public string PrehotTime { get; set; }
    }
}
