using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
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
        public string BoughtTime { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 招商报名数据总数
        /// </summary>
        [JsonProperty("item_count")]
        public string ItemCount { get; set; }

        /// <summary>
        /// 招商报名数据
        /// </summary>
        [JsonProperty("item_info")]
        public List<RecruitItemApplyData> ItemInfo { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 预热开始时间 2016-12-12 10:10:10
        /// </summary>
        [JsonProperty("prehot_time")]
        public string PrehotTime { get; set; }
    }
}
