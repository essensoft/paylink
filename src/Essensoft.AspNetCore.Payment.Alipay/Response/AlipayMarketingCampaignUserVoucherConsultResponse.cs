using System.Text.Json.Serialization;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignUserVoucherConsultResponse.
    /// </summary>
    public class AlipayMarketingCampaignUserVoucherConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 活动券领取咨询结果列表
        /// </summary>
        [JsonPropertyName("activity_consult_list")]
        public List<ActivityConsultInfo> ActivityConsultList { get; set; }
    }
}
