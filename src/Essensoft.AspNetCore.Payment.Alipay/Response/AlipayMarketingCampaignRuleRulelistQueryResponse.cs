using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignRuleRulelistQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignRuleRulelistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// [{"ruledesc":"圈人规则0","ruleid":"230291","status":"ENABLE"},  {"ruledesc":"圈人规则1","ruleid":"230292","status":"ENABLE"}]  说明:  ruledesc:规则描述信息  ruleid：规则id（唯一）  status：ENABLE（规则可使用），DISABLE（不可用）
        /// </summary>
        [JsonPropertyName("rulelist")]
        public List<CrowdRuleInfo> Rulelist { get; set; }
    }
}
