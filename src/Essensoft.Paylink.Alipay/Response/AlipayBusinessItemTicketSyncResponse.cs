using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayBusinessItemTicketSyncResponse.
    /// </summary>
    public class AlipayBusinessItemTicketSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝门票商品id
        /// </summary>
        [JsonPropertyName("object_id")]
        public string ObjectId { get; set; }

        /// <summary>
        /// 支付宝门票商品状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
