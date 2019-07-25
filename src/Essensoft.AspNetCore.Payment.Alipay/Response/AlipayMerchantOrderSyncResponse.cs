using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantOrderSyncResponse.
    /// </summary>
    public class AlipayMerchantOrderSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 同步成功后的订单号
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }
    }
}
