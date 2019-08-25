using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignRuleCrowdQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignRuleCrowdQueryModel : AlipayObject
    {
        /// <summary>
        /// 签约商户下属机构唯一编号
        /// </summary>
        [JsonProperty("mpid")]
        public string Mpid { get; set; }

        /// <summary>
        /// 所要查询的规则id
        /// </summary>
        [JsonProperty("ruleid")]
        public string Ruleid { get; set; }
    }
}
