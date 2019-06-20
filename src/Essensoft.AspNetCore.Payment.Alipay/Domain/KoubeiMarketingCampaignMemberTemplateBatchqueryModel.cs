using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignMemberTemplateBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignMemberTemplateBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 会员模板id
        /// </summary>
        [JsonProperty("member_template_ids")]
        public List<string> MemberTemplateIds { get; set; }
    }
}
