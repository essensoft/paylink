using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountBudgetCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignDiscountBudgetCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 预算ID
        /// </summary>
        [JsonProperty("budget_id")]
        [XmlElement("budget_id")]
        public string BudgetId { get; set; }
    }
}
