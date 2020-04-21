using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignRuleRulelistQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignRuleRulelistQueryModel : AlipayObject
    {
        /// <summary>
        /// 签约商户下属子机构唯一编号
        /// </summary>
        [JsonPropertyName("mpid")]
        public string Mpid { get; set; }

        /// <summary>
        /// 页码，从1开始
        /// </summary>
        [JsonPropertyName("pageno")]
        public string Pageno { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [JsonPropertyName("pagesize")]
        public string Pagesize { get; set; }
    }
}
