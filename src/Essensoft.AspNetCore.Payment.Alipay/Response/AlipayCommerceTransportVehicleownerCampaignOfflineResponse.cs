using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerCampaignOfflineResponse.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerCampaignOfflineResponse : AlipayResponse
    {
        /// <summary>
        /// 状态。P(审核中)、S(审核通过)、F(审核驳回)、I(初始状态)
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
