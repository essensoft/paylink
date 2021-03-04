using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerCampaignauditQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerCampaignauditQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
