using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceDataCampaignCreateResponse.
    /// </summary>
    public class AlipayCommerceDataCampaignCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 集点活动id
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }
    }
}
