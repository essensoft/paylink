using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignMemberTemplateOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignMemberTemplateOfflineModel : AlipayObject
    {
        /// <summary>
        /// 会员模板id
        /// </summary>
        [JsonProperty("member_template_id")]
        public string MemberTemplateId { get; set; }

        /// <summary>
        /// 请求ID，由开发者生成并保证唯一性
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }
}
