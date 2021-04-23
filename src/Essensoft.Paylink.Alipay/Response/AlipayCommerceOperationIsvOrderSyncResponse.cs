using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceOperationIsvOrderSyncResponse.
    /// </summary>
    public class AlipayCommerceOperationIsvOrderSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 同步订单记录id
        /// </summary>
        [JsonPropertyName("record_id")]
        public string RecordId { get; set; }
    }
}
