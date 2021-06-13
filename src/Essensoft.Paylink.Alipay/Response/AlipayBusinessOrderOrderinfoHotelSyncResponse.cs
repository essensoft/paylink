using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayBusinessOrderOrderinfoHotelSyncResponse.
    /// </summary>
    public class AlipayBusinessOrderOrderinfoHotelSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝酒店订单id
        /// </summary>
        [JsonPropertyName("object_id")]
        public string ObjectId { get; set; }

        /// <summary>
        /// 支付宝酒店订单状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
