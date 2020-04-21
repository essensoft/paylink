using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignMallInviteQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignMallInviteQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 平台活动招商信息列表
        /// </summary>
        [JsonPropertyName("activity_plan_info_list")]
        public List<ActivityPlanInfo> ActivityPlanInfoList { get; set; }
    }
}
