using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

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
        [JsonPropertyName("bought_time")]
        public string BoughtTime { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 招商报名数据总数
        /// </summary>
        [JsonPropertyName("item_count")]
        public string ItemCount { get; set; }

        /// <summary>
        /// 招商报名数据
        /// </summary>
        [JsonPropertyName("item_info")]
        public List<RecruitItemApplyData> ItemInfo { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 预热开始时间 2016-12-12 10:10:10
        /// </summary>
        [JsonPropertyName("prehot_time")]
        public string PrehotTime { get; set; }
    }
}
