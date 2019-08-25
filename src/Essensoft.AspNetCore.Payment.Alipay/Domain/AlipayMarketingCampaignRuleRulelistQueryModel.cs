using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignRuleRulelistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignRuleRulelistQueryModel : AlipayObject
    {
        /// <summary>
        /// 签约商户下属子机构唯一编号
        /// </summary>
        [JsonProperty("mpid")]
        public string Mpid { get; set; }

        /// <summary>
        /// 页码，从1开始
        /// </summary>
        [JsonProperty("pageno")]
        public string Pageno { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [JsonProperty("pagesize")]
        public string Pagesize { get; set; }
    }
}
