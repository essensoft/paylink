using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringEleOrderSyncResponse.
    /// </summary>
    public class KoubeiCateringEleOrderSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 原始的订单id编号
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }
    }
}
