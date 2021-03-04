using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayBusinessItemExternalSyncResponse.
    /// </summary>
    public class AlipayBusinessItemExternalSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝商品id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 入参中的request_id
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
