using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignRuleCrowdQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignRuleCrowdQueryModel : AlipayObject
    {
        /// <summary>
        /// 签约商户下属机构唯一编号
        /// </summary>
        [JsonPropertyName("mpid")]
        public string Mpid { get; set; }

        /// <summary>
        /// 所要查询的规则id
        /// </summary>
        [JsonPropertyName("ruleid")]
        public string Ruleid { get; set; }
    }
}
