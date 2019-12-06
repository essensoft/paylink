using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignRetailDmQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignRetailDmQueryModel : AlipayObject
    {
        /// <summary>
        /// 内容id，通过调用koubei.marketing.campaign.retail.dm.create接口创建内容时返回的内容ID
        /// </summary>
        [JsonPropertyName("content_id")]
        public string ContentId { get; set; }
    }
}
