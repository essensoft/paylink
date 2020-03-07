using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignMerchantActivityQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignMerchantActivityQueryModel : AlipayObject
    {
        /// <summary>
        /// 口碑营销活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 请求id，方便幂等控制和排查问题，请保证唯一
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
