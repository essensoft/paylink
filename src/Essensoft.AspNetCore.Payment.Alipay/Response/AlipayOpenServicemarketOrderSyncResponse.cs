using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenServicemarketOrderSyncResponse.
    /// </summary>
    public class AlipayOpenServicemarketOrderSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 服务市场订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }
    }
}
