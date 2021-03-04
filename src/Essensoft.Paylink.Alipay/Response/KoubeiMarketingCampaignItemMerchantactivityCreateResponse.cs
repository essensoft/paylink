using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityCreateResponse.
    /// </summary>
    public class KoubeiMarketingCampaignItemMerchantactivityCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 运营活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }
    }
}
