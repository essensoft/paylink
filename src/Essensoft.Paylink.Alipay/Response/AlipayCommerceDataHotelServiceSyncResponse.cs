using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceDataHotelServiceSyncResponse.
    /// </summary>
    public class AlipayCommerceDataHotelServiceSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝行业侧服务的标识
        /// </summary>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }
    }
}
