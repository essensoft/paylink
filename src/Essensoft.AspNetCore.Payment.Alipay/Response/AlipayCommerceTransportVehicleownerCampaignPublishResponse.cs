using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerCampaignPublishResponse.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerCampaignPublishResponse : AlipayResponse
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
